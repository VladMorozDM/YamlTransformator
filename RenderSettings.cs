using YamlTransformer.interfaces;

namespace YamlTransformer
{
    public class RenderSettings
    {
        public int m_ObjectHideFlags { get; set; }
        public int SerializedVersion { get; set; }
        public int m_Fog { get; set; }
        public Rgba m_FogColor { get; set; }
        public int m_FogMode { get; set; }
        public float m_FogDensity { get; set; }
        public FieldId m_Sun { get; set; }

        public RenderSettings(int mObjectHideFlags, int serializedVersion, int mFog, Rgba mFogColor, int mFogMode, float mFogDensity, FieldId mSun)
        {
            m_ObjectHideFlags = mObjectHideFlags;
            SerializedVersion = serializedVersion;
            m_Fog = mFog;
            m_FogColor = mFogColor;
            m_FogMode = mFogMode;
            m_FogDensity = mFogDensity;
            m_Sun = mSun;
        }
    }
}