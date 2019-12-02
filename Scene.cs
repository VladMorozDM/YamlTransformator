using System.Collections.Generic;

namespace YamlTransformer
{
    public class Scene
    {
        public LightmapSettings LightmapSettings { get; set; }
        public MonoBehaviour[] MonoBehaviours { get; set; }
        public GameObject[] GameObjects { get; set; }
        public RenderSettings RenderSettings { get; set; }
        public OcclusionSettings OcclusionSettings { get; set; }

        public Scene(LightmapSettings lightSettings, MonoBehaviour[] behaviours, GameObject[] gameObjects, RenderSettings renderSettings, OcclusionSettings occlusion)
        {
            LightmapSettings = lightSettings;
            MonoBehaviours = behaviours;
            GameObjects = gameObjects;
            RenderSettings = renderSettings;
            OcclusionSettings = occlusion;
        }
    }
}