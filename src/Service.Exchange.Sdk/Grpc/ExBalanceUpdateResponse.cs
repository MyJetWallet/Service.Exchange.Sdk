using System.Collections.Generic;
using System.Runtime.Serialization;
using Service.Exchange.Sdk.Messages;

namespace Service.Exchange.Sdk.Grpc
{
    [DataContract]
    public class ExBalanceUpdateResponse : Response<List<ExBalanceUpdate>>
    {
    }
}