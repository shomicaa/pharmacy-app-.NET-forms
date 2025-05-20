using System.Text.Json;

namespace Common
{
    [Serializable]
    public class Request
    {
        public Operation Operation { get; set; }
        public object RequestObject { get; set; }

        public T GetRequestObject<T>()
        {
            if (RequestObject is JsonElement jsonElement)
            {
                return jsonElement.Deserialize<T>();
            }
            return (T)RequestObject;
        }
    }

    public class Request<T>
    {
        public Operation Operation { get; set; }
        public T RequestObject { get; set; }
    }
}
