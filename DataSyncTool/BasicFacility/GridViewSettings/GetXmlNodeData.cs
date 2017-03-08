/// <copyright from='2003'' to='2010' company='����������Ϣ�������޹�˾'>
///    Copyright(c) ����������Ϣ�������޹�˾��Ȩ����.                
/// </copyright>                                                                
//------------------------------------------------------------------------------
/*******************************************************************************/
/*      FileName: GetXmlNodeData.cs  
/*      Function: ��ȡXml�ļ��Ľڵ���Ϣ 
/*        Author: л���� 
/*          Date: 2004-10-20 
/*******************************************************************************/
using System;
using System.Data;
using System.IO;
using System.Xml;

namespace BasicFacility.GridViewSettings
{
    /// <summary>
    /// ��ȡXml�ļ��Ľڵ���Ϣ
    /// </summary>
    public class GetXmlNodeData
    {
        public GetXmlNodeData()
        {
        }

        //##############################################################################
        /// <summary>
        /// ��ȡXml�ļ��Ľڵ���Ϣ
        /// Coder: ��־����2004-04-13�� 
        /// </summary>
        /// <param name="sFileName">�ļ���</param>
        /// <param name="sNodeName">�ڵ���</param>
        /// <returns>�ڵ���Ϣ</returns>
        //##############################################################################
        public static string GetXmlData(string sFileName,string sNodeName)
        {
            string sDisplayCols = "";
            try
            {
                //��������ʾ�����ļ�
                FileStream fs = new FileStream( sFileName, FileMode.Open );
                XmlTextReader reader = new XmlTextReader( fs );

                while( reader.Read() )
                {
                    string sCurNodeName = reader.LocalName.ToLower();

                    if( sCurNodeName == sNodeName.ToLower() )
                        sDisplayCols = reader.ReadElementString();
                }
                fs.Close();
            }			
            catch{}
            return sDisplayCols;
        }

        //##############################################################################
        /// <summary>
        /// ����View��Column��
        /// Coder: ��־����2004-04-13�� 
        /// </summary>
        /// <param name="xgrid">�����ص�grid</param>
        /// <param name="xgridView">�����ص�gridView</param>
        /// <param name="sDisplayCols">��ʾ��</param>
        /// <param name="ColumnStruct">��ʾ�Ľṹ</param>
        //##############################################################################
        public static void SetColumnData( DevExpress.XtraGrid.GridControl xgrid,
                                          DevExpress.XtraGrid.Views.Grid.GridView xgridView,
                                          string sDisplayCols,
                                          ColumnStruct ColumnStruct)
        {
            xgridView.Columns.Clear();
            if (sDisplayCols.Length == 0)  // ����ʾ��
            {
                return;
            }
            xgrid.BeginUpdate();
            DevExpress.XtraGrid.Columns.GridColumn clm;
            //���������ļ���������ʾ����
            for (int i = 0; i < sDisplayCols.Length; i++)
            {
                for (int j = 0; j < ColumnStruct.clmStruct.Length; j++)
                {
                    //if (ColumnStruct.clmStruct[j].Tag.ToString().ToUpper() == sDisplayCols[i].ToString().ToUpper())
                    if (ColumnStruct.clmStruct[j].Tag == sDisplayCols[i].ToString())
                    {
                        clm = xgridView.Columns.Add();
                        clm.FieldName = ColumnStruct.clmStruct[j].FieldName;
                        clm.Caption = ColumnStruct.clmStruct[j].CaptionName;
                        clm.Width = Convert.ToInt32(ColumnStruct.clmStruct[j].Width);
                        clm.VisibleIndex = i;
                        clm.OptionsColumn.AllowEdit = false;
                    }
                }
            }
            xgrid.EndUpdate();
        }
    }
}