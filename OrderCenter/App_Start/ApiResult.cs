using Newtonsoft.Json;

namespace OrderCenter
{
    /// <summary>
    /// API结果标记接口
    /// </summary>
    public interface IApiResult { }
    /// <summary>
    /// 统一接口Json返回结果格式
    /// </summary>
    public class ApiResult : IApiResult
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [JsonProperty(PropertyName = "c")]
        public uint ReturnCode { get; set; }
        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonIgnore]
        public bool Success => ReturnCode == 0;

        /// <summary>
        /// 附加消息
        /// </summary>
        [JsonProperty(PropertyName = "m")]
        public string Message { get; set; }
        /// <summary>
        /// 返回码
        /// </summary>
        [JsonProperty(PropertyName = "t")]
        public int Total { get; set; }
    }

    /// <summary>
    /// 统一接口Json返回结果格式
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResult<T> : ApiResult
    {
        /// <summary>
        /// 附加数据
        /// </summary>
        [JsonProperty(PropertyName = "d")]
        public T Result { get; set; }
    }

}