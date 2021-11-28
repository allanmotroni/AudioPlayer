namespace AudioPlayerUtils.Interfaces
{
    public interface ICustomJsonConvert
    {
        T Deserializar<T>(string json);

        string Serializar<T>(T lista);        
    }
}
