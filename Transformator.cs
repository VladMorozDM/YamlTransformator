using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YamlDotNet.Serialization;
using YamlTransformer.interfaces;

namespace YamlTransformer
{
    public static class Transformator
    {
        private static int HideFlag { get; set; } = 0;
        private static int SerializedVersionGameObjects { get; set; } = 6;
        private static int SerializedVersionSettings { get; set; } = 9;

        static string ConvertJsonToYaml(string json)
        {
            JGameObject[] jsonGameObjects = JsonConvert.DeserializeObject<JGameObject[]>(json);
            
            OcclusionSettings occlusionSettings = new OcclusionSettings();
            LightmapSettings lightmapSettings = new LightmapSettings();
            MonoBehaviour[] monoBehaviours = {
                new MonoBehaviour()
            };
            GameObject[] gameObjects = {};

            for (int i = 0; i < jsonGameObjects.Length; i++)
            {
                gameObjects[i] = new GameObject(HideFlag, SerializedVersionGameObjects, jsonGameObjects[i].name);
            }
            
            
            RenderSettings renderSettings = new RenderSettings();
            OcclusionSettings occlusionSettingss = new OcclusionSettings();
            

            Scene scene = new Scene(lightmapSettings, monoBehaviours, gameObjects, renderSettings, occlusionSettingss);

            var serializer = new SerializerBuilder().Build();
            string yamlScene = serializer.Serialize(scene);

            return yamlScene;
        }
    }
}