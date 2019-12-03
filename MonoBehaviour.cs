using YamlTransformer.interfaces;

namespace YamlTransformer
{
    public class MonoBehaviour
    {
        public int m_ObjectHideFlags { get; set; } = 0;
        public FieldId m_CorrespondingSourceObject { get; set; } = new FieldId();
        public FieldId m_PrefabInstance { get; set; } = new FieldId();
        public FieldId m_PrefabAsset { get; set; } = new FieldId();
        public FieldId m_GameObject { get; set; } = new FieldId();
        public int m_Enabled { get; set; }
        public ScriptField m_Script { get; set; }

        public MonoBehaviour(int mEnabled, ScriptField mScript)
        {
            m_Enabled = mEnabled;
            m_Script = mScript;
        }
    }
}