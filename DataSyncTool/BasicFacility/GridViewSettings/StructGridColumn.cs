/// <copyright from='2003'' to='2004' company='����������Ϣ�������޹�˾'>
///    Copyright(c) ����������Ϣ�������޹�˾��Ȩ����.                
/// </copyright>                                                                
//------------------------------------------------------------------------------
/*******************************************************************************/
/*      FileName: StructGridColumn.cs                                          */
/*      Function: ����Grid�б����ݵ���ʾ									   */
/*        Author: ��Ԫ��                                                       */
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
    /// ������֯Grid�б�����ݵ����ݽṹ
    /// </summary>
    public struct CommColumnStruct
    {
        private string filedName;	 // filedName  ��� filedname 
        private string captionName;  // captionName ��� caption
        private int width;        // width ��� Width
        private string tag;			 // tag ���Column��˳�� 	

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