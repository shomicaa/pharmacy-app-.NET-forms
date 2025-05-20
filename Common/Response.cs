using System.Text.Json;

namespace Common
{
    [Serializable]
    public class Response
    {
        public string Message { get; set; } = "Success!";
        public bool IsSuccessful { get; set; } = true;
        public object Result { get; set; }

        public T GetResult<T>()
        {
            if (Result is JsonElement jsonElement)
            {
                return jsonElement.Deserialize<T>();
            }
            return (T)Result;
        }
    }
    public class Response<T>
    {
        public string Message { get; set; } = "Success!";
        public bool IsSuccessful { get; set; } = true;
        public T Result { get; set; }
    }
}
