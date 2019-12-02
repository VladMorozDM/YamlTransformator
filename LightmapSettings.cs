using YamlTransformer.interfaces;

namespace YamlTransformer
{
    public class LightmapSettings
    {
        public int m_ObjectHideFlags { get; set; }
        public int m_SerializationVersion { get; set; }
        public int GIWorkFlowMode { get; set; }
        public FieldId FieldId { get; set; }

        public LightmapSettings(int mObjectHideFlags, int mSerializationVersion, int giWorkFlowMode, FieldId fieldId)
        {
            m_ObjectHideFlags = mObjectHideFlags;
            m_SerializationVersion = mSerializationVersion;
            GIWorkFlowMode = giWorkFlowMode;
            FieldId = fieldId; 
        }
    }
}