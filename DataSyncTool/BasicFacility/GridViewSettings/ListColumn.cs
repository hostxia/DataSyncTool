
namespace BasicFacility.GridViewSettings
{
    public struct ListColumn
    {
        public ListColumn(string caption, string fieldName, int width, bool isAdvCol) : this()
        {
            Caption = caption;
            FieldName = fieldName;
            Width = width;
            IsAdvanced = isAdvCol;
        }

        public string Caption { get; set; }
        public string FieldName { get; set; }
        public int Width{ get; set; }
        public bool IsAdvanced { get; set; }
    }
}