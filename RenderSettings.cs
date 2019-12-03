using YamlTransformer.interfaces;

namespace YamlTransformer
{
    public class RenderSettings
    {
        public int m_ObjectHideFlags { get; set; }
        public int SerializedVersion { get; set; }
        public int m_Fog { get; set; } = 1;
        public int m_FogMode { get; set; } = 10;
        public double m_FogDensity { get; set; } = 0.1;
        public FieldId m_Sun { get; set; } = new FieldId();

        public RenderSettings(int mObjectHideFlags, int serializedVersion)
        {
            m_ObjectHideFlags = mObjectHideFlags;
            SerializedVersion = serializedVersion;
        }
    }
}