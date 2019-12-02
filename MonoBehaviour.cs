using YamlTransformer.interfaces;

namespace YamlTransformer
{
    public class MonoBehaviour
    {
        public int m_ObjectHideFlags { get; set; }
        public FieldId m_CorrespondingSourceObject { get; set; }
        public FieldId m_PrefabInstance { get; set; }
        public FieldId m_PrefabAsset { get; set; }
        public FieldId m_GameObject { get; set; }
        public int m_Enabled { get; set; }
        public ScriptField m_Script { get; set; }

        public MonoBehaviour(int mObjectHideFlags, FieldId mCorrespondingSourceObject, FieldId mPrefabInstance, FieldId mPrefabAsset, FieldId mGameObject, int mEnabled, ScriptField mScript)
        {
            m_ObjectHideFlags = mObjectHideFlags;
            m_CorrespondingSourceObject = mCorrespondingSourceObject;
            m_PrefabInstance = mPrefabInstance;
            m_PrefabAsset = mPrefabAsset;
            m_GameObject = mGameObject;
            m_Enabled = mEnabled;
            m_Script = mScript;
        }
    }
}