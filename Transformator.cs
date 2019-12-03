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
        private static ScriptField playerScript { get; set; } = new ScriptField();

        static string ConvertJsonToYaml(string json)
        {
            JGameObject[] jsonGameObjects = JsonConvert.DeserializeObject<JGameObject[]>(json);
            
            OcclusionSettings occlusionSettings = new OcclusionSettings();
            LightmapSettings lightmapSettings = new LightmapSettings(HideFlag, SerializedVersionSettings, 1, new FieldId());
            MonoBehaviour[] monoBehaviours = {
                new MonoBehaviour(1, playerScript)
            };
            GameObject[] gameObjects = {};

            for (int i = 0; i < jsonGameObjects.Length; i++)
            {
                gameObjects[i] = new GameObject(SerializedVersionGameObjects, jsonGameObjects[i].name);
            }
            
            
            RenderSettings renderSettings = new RenderSettings(HideFlag, SerializedVersionSettings);
            OcclusionSettings occlusionSettingss = new OcclusionSettings();
            

            Scene scene = new Scene(lightmapSettings, monoBehaviours, gameObjects, renderSettings, occlusionSettingss);

            var serializer = new SerializerBuilder().Build();
            string yamlScene = serializer.Serialize(scene);

            return yamlScene;
        }
    }
}