using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Service.Exchange.Sdk.Grpc
{
    [DataContract]
    public class CancelOrderRequest
    {
        [DataMember(Order = 2)] public string WalletId { get; set; }
        [DataMember(Order = 3)] public string AssetPairId { get; set; }
        [DataMember(Order = 1)] public List<string> OrdersIds { get; set; }
    }
}