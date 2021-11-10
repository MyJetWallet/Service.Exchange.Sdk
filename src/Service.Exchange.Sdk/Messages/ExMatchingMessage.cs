using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Service.Exchange.Sdk.Models;

namespace Service.Exchange.Sdk.Messages
{
    [DataContract]
    public class ExMatchingMessage
    {
        [DataMember(Order = 1)] public MessageCommand Command { get; set; }
        [DataMember(Order = 2)] public string OperationId { get; set; }
        //init address?
        [DataMember(Order = 3)] public string Instance { get; set; }
        [DataMember(Order = 4)] public DateTime Timestamp { get; set; }
        [DataMember(Order = 5)] public string AssetPairId { get; set; }

        [DataMember(Order = 6)] public List<OrderUpdate> Updates { get; set; }
        [DataMember(Order = 7)] public MatchingInstruction Match { get; set; }


        [DataContract]
        public class MatchingInstruction
        {
            [DataMember(Order = 1)] public List<MatchedOrder> Takers { get; set; }
            [DataMember(Order = 2)] public List<MatchedOrder> Makers { get; set; }
        }

        [DataContract]
        public enum MessageCommand
        {
            Unknown = 0,
            OrderChange = 1,
            InitMe = 2
        }

        [DataContract]
        public enum OrderAction
        {
            Unknown = 0,
            Placed = 1,
            Updated = 2,
            Canceled = 3,
            Executed = 4
        }

        [DataContract]
        public class OrderUpdate
        {
            [DataMember(Order = 1)] public OrderAction Action { get; set; }
            [DataMember(Order = 2)] public ExOrder Order { get; set; }
        }

        [DataContract]
        public class MatchedOrder
        {
            [DataMember(Order = 1)] public uint Number { get; set; }
            [DataMember(Order = 2)] public string TradeId { get; set; }
            [DataMember(Order = 3)] public ExOrder Order { get; set; }
            [DataMember(Order = 4)] public decimal Amount { get; set; }
            [DataMember(Order = 5)] public Fee Fee { get; set; }
            [DataMember(Order = 6)] public ExOrder OppositeOrder { get; set; }
            [DataMember(Order = 7)] public decimal OppositeAmount { get; set; }
            [DataMember(Order = 8)] public Fee OppositeFee { get; set; }
            [DataMember(Order = 9)] public decimal Price { get; set; }
        }
        
        [DataContract]
        public class Fee
        {
            [DataMember(Order = 1)] public string OrderId { get; set; }
            [DataMember(Order = 2)] public string TradeId { get; set; }
            [DataMember(Order = 3)] public string Asset { get; set; }
            [DataMember(Order = 4)] public decimal Amount { get; set; }
            [DataMember(Order = 5)] public string SourceWalletId { get; set; }
            [DataMember(Order = 6)] public string TargetWalletId { get; set; }
        }
    }
}