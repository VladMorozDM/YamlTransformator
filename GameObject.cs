using YamlTransformer.interfaces;

namespace YamlTransformer
{
    public class GameObject
    {
        public int m_ObjectHideFlags { get; set; } = 0;
        public FieldId m_CorrespondingSourceObject { get; set; } = new FieldId();
        public FieldId m_PrefabInstance { get; set; } = new FieldId();
        public FieldId m_PrefabAsset { get; set; } = new FieldId();
        public int SerializedVersion { get; set; }
        public string m_Name { get; set; }
        public FieldId m_Component { get; set; } = new FieldId();

        public GameObject(int serializedVersion, string mName)
        {
            SerializedVersion = serializedVersion;
            m_Name = mName;
        }
    }
}