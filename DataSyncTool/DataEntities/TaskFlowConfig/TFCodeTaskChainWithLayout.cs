using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TFCode_TaskChainLayout")]
    public class TFCodeTaskChainWithLayout : TFCodeTaskChain
    {
        string fs_Layout;
        [Size(SizeAttribute.Unlimited)]
        public string s_Layout
        {
            get { return fs_Layout; }
            set { SetPropertyValue<string>("s_Layout", ref fs_Layout, value); }
        }

        public TFCodeTaskChainWithLayout(Session session) : base(session) { }
    }
}