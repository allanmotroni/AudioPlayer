using AudioPlayerUtils.Interfaces;
using Newtonsoft.Json;

namespace AudioPlayerDatabase
{
    public class CustomJsonConvert : ICustomJsonConvert
    {
        public T Deserializar<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public string Serializar<T>(T lista)
        {
            return JsonConvert.SerializeObject(lista);
        }
    }
}
