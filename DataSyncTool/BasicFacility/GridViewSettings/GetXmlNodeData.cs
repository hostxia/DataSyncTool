/// <copyright from='2003'' to='2010' company='北京彼速信息技术有限公司'>
///    Copyright(c) 北京彼速信息技术有限公司版权所有.                
/// </copyright>                                                                
//------------------------------------------------------------------------------
/*******************************************************************************/
/*      FileName: GetXmlNodeData.cs  
/*      Function: 获取Xml文件的节点信息 
/*        Author: 谢国利 
/*          Date: 2004-10-20 
/*******************************************************************************/
using System;
using System.Data;
using System.IO;
using System.Xml;

namespace BasicFacility.GridViewSettings
{
    /// <summary>
    /// 获取Xml文件的节点信息
    /// </summary>
    public class GetXmlNodeData
    {
        public GetXmlNodeData()
        {
        }

        //##############################################################################
        /// <summary>
        /// 读取Xml文件的节点信息
        /// Coder: 张志国（2004-04-13） 
        /// </summary>
        /// <param name="sFileName">文件名</param>
        /// <param name="sNodeName">节点名</param>
        /// <returns>节点信息</returns>
        //##############################################################################
        public static string GetXmlData(string sFileName,string sNodeName)
        {
            string sDisplayCols = "";
            try
            {
                //调用列显示配置文件
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
        /// 加载View的Column项
        /// Coder: 张志国（2004-04-13） 
        /// </summary>
        /// <param name="xgrid">待加载的grid</param>
        /// <param name="xgridView">待加载的gridView</param>
        /// <param name="sDisplayCols">显示项</param>
        /// <param name="ColumnStruct">显示的结构</param>
        //##############################################################################
        public static void SetColumnData( DevExpress.XtraGrid.GridControl xgrid,
                                          DevExpress.XtraGrid.Views.Grid.GridView xgridView,
                                          string sDisplayCols,
                                          ColumnStruct ColumnStruct)
        {
            xgridView.Columns.Clear();
            if (sDisplayCols.Length == 0)  // 无显示列
            {
                return;
            }
            xgrid.BeginUpdate();
            DevExpress.XtraGrid.Columns.GridColumn clm;
            //根据配置文件加载列显示内容
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