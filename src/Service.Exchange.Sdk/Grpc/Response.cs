using System.Runtime.Serialization;

namespace Service.Exchange.Sdk.Grpc
{
    [DataContract]
    public class Response<T>
    {
        [DataMember(Order = 1)] public T Data { get; set; }
        [DataMember(Order = 2)] public StatusCode Status { get; set; }
        [DataMember(Order = 3)] public string ErrorMessage { get; set; }
        [DataMember(Order = 4)] public bool IsSuccess { get; set; }

        public static Response<T> Success(T data)
        {
            return new Response<T>()
            {
                Data = data,
                Status = StatusCode.Ok,
                IsSuccess = true
            };
        }

        public static Response<T> Error(StatusCode code, string errorMessage)
        {
            return new Response<T>()
            {
                Status = code,
                ErrorMessage = errorMessage,
                IsSuccess = false
            };
        }
        
        public enum StatusCode
        {
            Unknown = 0,
            Ok = 1,
            Duplicate = 2,
            Failed = 3,
            LowBalance = 4
        }
    }
}