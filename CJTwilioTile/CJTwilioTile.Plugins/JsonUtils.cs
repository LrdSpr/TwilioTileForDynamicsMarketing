using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace CJTwilioTile
{
    public static class JsonUtils
    {
         public static T Deserialize<T>(string json, DataContractJsonSerializerSettings settings = null)
        {
            if (typeof(T) == typeof(string))
            {
                return (T)(object)json;
            }
            using (MemoryStream stream = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializerSettings JsonSerializerSettings = settings ?? new DataContractJsonSerializerSettings
                {
                    UseSimpleDictionaryFormat = true
                };
                return (T)new DataContractJsonSerializer(typeof(T), JsonSerializerSettings).ReadObject(stream);
            }
        }
    }
}
