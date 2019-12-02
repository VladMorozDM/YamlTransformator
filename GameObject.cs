using YamlTransformer.interfaces;

namespace YamlTransformer
{
    public class GameObject
    {
        public int m_ObjectHideFlags { get; set; }
//        public FieldId m_CorrespondingSourceObject { get; set; }
//        public FieldId m_PrefabInstance { get; set; }
//        public FieldId m_PrefabAsset { get; set; }
        public int SerializedVersion { get; set; }
        public string m_Name { get; set; }
//        public FieldId m_Component { get; set; }

        public GameObject(int mObjectHideFlags, int serializedVersion, string mName)
        {
            m_ObjectHideFlags = mObjectHideFlags;
//            m_CorrespondingSourceObject = mCorrespondingSourceObject;
//            m_PrefabInstance = mPrefabInstance;
//            m_PrefabAsset = mPrefabAsset;
            SerializedVersion = serializedVersion;
            m_Name = mName;
//            m_Component = mComponent;
        }
    }
}