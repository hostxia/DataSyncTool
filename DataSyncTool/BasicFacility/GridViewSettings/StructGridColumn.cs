/// <copyright from='2003'' to='2004' company='北京彼速信息技术有限公司'>
///    Copyright(c) 北京彼速信息技术有限公司版权所有.                
/// </copyright>                                                                
//------------------------------------------------------------------------------
/*******************************************************************************/
/*      FileName: StructGridColumn.cs                                          */
/*      Function: 用于Grid列表数据的显示									   */
/*        Author: 贾元华                                                       */
/*          Date: 2004-3-9                                                     */
/*******************************************************************************/
namespace BasicFacility.GridViewSettings
{
    public struct ColumnStruct
    {
        private string shidename;
        private string sshowname;
        CommColumnStruct[] clmstruct;
        public ColumnStruct(string shidename , string sshowname, CommColumnStruct[] clmstruct)
        {
            this.shidename = shidename;
            this.sshowname  = sshowname;
            this.clmstruct	 = clmstruct; 
        }
        public string sHideName 
        { 
            get{ return shidename; } 
        }

        public string sShowName 
        { 
            get{ return sshowname; } 
        }

        public CommColumnStruct[] clmStruct 
        { 
            get{ return clmstruct; } 
        }
    }

    /// <summary>
    /// 用于组织Grid列表的数据的数据结构
    /// </summary>
    public struct CommColumnStruct
    {
        private string filedName;	 // filedName  存放 filedname 
        private string captionName;  // captionName 存放 caption
        private int width;        // width 存放 Width
        private string tag;			 // tag 存放Column的顺序 	

        public CommColumnStruct(string longName , string shortName, string tag, int width)
        {
            this.captionName = longName;
            this.filedName	 = shortName;
            this.tag		 = tag; 
            this.width       = width;
        }
	
        public string FieldName 
        { 
            get{ return filedName; } 
        }

        public string CaptionName 
        { 
            get{ return captionName; } 
        }

        public int Width 
        { 
            get{ return width; } 
        }

        public string Tag 
        { 
            get{ return tag; } 
        }
    }
}