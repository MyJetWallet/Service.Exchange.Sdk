using System.Collections.Generic;
using System.Runtime.Serialization;
using Service.Exchange.Sdk.Models;

namespace Service.Exchange.Sdk.Grpc
{
    [DataContract]
    public class CancelOrderResponse : Response<List<ExOrder>>
    {
    }
}