using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using BasicFacility.Exceptions;
//using DataAccessors.CodeAccessor;
//using DataEntities.Codes;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
//using Foundation.Enums;

namespace BasicFacility.GridViewSettings
{
    public class GridViewOperators
    {
        /// #################################################################
        /// <summary>
        /// 判断Columns中是否含有高级字段
        /// Coder: Gary(2010-06-26)
        /// </summary>
        /// <param name="gridColumns">GridView的Columns</param>
        /// <param name="allColumns">ListColumn[]</param>
        /// <returns>有，则返回true</returns>
        public static bool ContainAdvColumn(GridColumnCollection gridColumns, IList<ListColumn> allColumns)
        {
            for (int i = 0; i < gridColumns.Count; i++)
            {
                foreach (ListColumn column in allColumns)
                {
                    if (column.Caption == gridColumns[i].Caption && !column.IsAdvanced)
                    {
                        break;
                    }
                    if (column.Caption == gridColumns[i].Caption && column.IsAdvanced)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        ///############################################################
        /// <summary>
        /// 从xml文件加载GridView的Layout，如果文件不存在，则去数据库中该模块的第一个Layout
        /// coder:Gary(2010-06-26)
        /// </summary>
        public static void LoadGridLayout(GridView xgridView, string moduleName)
        {
            string layoutPath = string.Format("{0}\\Layout\\", Application.StartupPath);
            string layoutFile = string.Format("{0}\\{1}.xml", layoutPath, moduleName);

            //if (!File.Exists(layoutFile))
            //{
            //    if (!Directory.Exists(layoutPath))
            //    {
            //        Directory.CreateDirectory(layoutPath);
            //    }
            //    //TODO :为了兼容性，注释掉这段语句
            //    #region MyRegion                                
            //    //var uow = new UnitOfWork();
            //    //XPCollection layouts = GridLayoutAccessor.GetCodeGridLayouts(uow, moduleName);
            //    //if (layouts.Count == 0) return;

            //    //var sw = new StreamWriter(layoutFile, false);
            //    //sw.Write(((CodeGridLayout)(layouts[0])).s_LayoutXml);
            //    //sw.Close();
            //    #endregion
            //}

            //xgridView.RestoreLayoutFromXml(layoutFile, DevExpress.Utils.OptionsLayoutBase.FullLayout);
        }

        ///############################################################
        /// <summary>
        /// 从数据库中加载Layout样式到当前GridView列表,并保存为xml
        /// coder:Gary(2010-06-26)
        /// </summary>
        public static void LoadLayoutToGridAndSaveToXml(GridView xgridView, int layoutID)
        {
            //var uow = new UnitOfWork();
            //CodeGridLayout layout = GridLayoutAccessor.GetCodeGridLayout(uow, layoutID);

            //if (layout == null) return;

            //string layoutPath = string.Format("{0}\\Layout\\", Application.StartupPath);
            //string layoutFile = string.Format("{0}\\{1}.xml", layoutPath, layout.s_ModuleName);

            //if (!Directory.Exists(layoutPath))
            //{
            //    Directory.CreateDirectory(layoutPath);
            //}

            //var sw = new StreamWriter(layoutFile, false);
            //sw.Write(layout.s_LayoutXml);
            //sw.Close();

            //xgridView.RestoreLayoutFromXml(layoutFile, DevExpress.Utils.OptionsLayoutBase.FullLayout);
        }

        /// ##############################################################
        /// <summary>
        /// 保存当前列表Layout到xml格式
        /// coder:Gary(2010-06-26)
        /// </summary>
        /// <param name="xGridView"></param>
        /// <param name="moduleName"></param>
        public static void SaveLayoutToXmlFile(GridView xGridView, string moduleName)
        {
            string tempFileName = string.Format("{0}\\Layout\\{1}.xml", Application.StartupPath, moduleName);
            xGridView.SaveLayoutToXml(tempFileName, DevExpress.Utils.OptionsLayoutBase.FullLayout);
        }

        /// #################################################################
        /// <summary>
        /// 从xml文件中读取指定模块的layout，返回字串
        /// Coder: Gary(2010-06-26)
        /// </summary>
        /// <param name="moduleName">模块名</param>
        /// <returns></returns>
        public static string ReadLayoutToXmlFile(string moduleName)
        {
            string tempFileName = string.Format("{0}\\Layout\\{1}.xml", Application.StartupPath, moduleName);

            if (File.Exists(tempFileName))
            {
                var streamReader = new StreamReader(tempFileName);
                string sLayoutXml = streamReader.ReadToEnd();
                streamReader.Close();

                return sLayoutXml;
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        /// 从模块的列配置文件（xml文件）中读入列配置
        /// Coder: Gary(2010-06-28)
        /// </summary>
        /// <param name="moduleName"></param>
        /// <returns></returns>
        public static IList<ListColumn> GetAvailableColumns(string moduleName)
        {
            IList<ListColumn> columns = new List<ListColumn>();

            string columnFile = string.Format("{0}\\Layout\\Columns\\{1}Columns.xml", Application.StartupPath, moduleName); // 模块的列配置文件（xml文件）
            if (!File.Exists(columnFile)) return columns;

            try
            {
                //var streamReader = new StreamReader(columnFile);
                //string xmlString = streamReader.ReadToEnd();
                //streamReader.Close();

                var xmlDoc = new XmlDocument();
                //xmlDoc.Load(new StringReader(xmlString)); //载入XML 
                xmlDoc.Load(columnFile);

                XmlNode root = xmlDoc.SelectSingleNode("/columns"); //获取根结点
                if (root == null) return null;

                var listColumn = new ListColumn();

                foreach (XmlNode columnNode in root.ChildNodes)
                {
                    listColumn.Caption = columnNode.SelectSingleNode("caption").InnerText.Trim();
                    listColumn.FieldName = columnNode.SelectSingleNode("fieldname").InnerText.Trim();
                    listColumn.Width = Convert.ToInt32(columnNode.SelectSingleNode("width").InnerText.Trim());
                    listColumn.IsAdvanced = columnNode.SelectSingleNode("isadvanced").InnerText.Trim() == "Y";

                    columns.Add(listColumn);
                }
            }
            catch (Exception ex)
            {
                ExManager.ReportException(ex);
                return columns;
            }
            return columns;
        }
    }
}