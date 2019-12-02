namespace YamlTransformer
{
    public class Scene
    {
        public LightmapSettings LightmapSettings { get; set; }
        public MonoBehaviour MonoBehaviour { get; set; }
        public GameObject GameObject { get; set; }
        public RenderSettings RenderSettings { get; set; }
        public OcclusionSettings OcclusionSettings { get; set; }

        public Scene(LightmapSettings lightSettings, MonoBehaviour behaviour, GameObject gameObject, RenderSettings renderSettings, OcclusionSettings occlusion)
        {
            LightmapSettings = lightSettings;
            MonoBehaviour = behaviour;
            GameObject = gameObject;
            RenderSettings = renderSettings;
            OcclusionSettings = occlusion;
        }   
    }
}