using System.Collections.Generic;
using System.Runtime.Serialization;
using Service.Exchange.Sdk.Messages;

namespace Service.Exchange.Sdk.Grpc
{
    [DataContract]
    public class ExBalanceUpdateRequest
    {
        [DataMember(Order = 1)] public List<ExBalanceUpdateInstruction> BalanceUpdateInstructions { get; set; }
    }
}