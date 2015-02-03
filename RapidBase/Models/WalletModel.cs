﻿using NBitcoin;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RapidBase.Models
{
    public class InsertWalletAddress
    {
        public bool MergePast
        {
            get;
            set;
        }
        public WalletAddress Address
        {
            get;
            set;
        }
    }
    public class WalletAddress
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BitcoinAddress Address
        {
            get;
            set;
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Script RedeemScript
        {
            get;
            set;
        }
        public JToken CustomData
        {
            get;
            set;
        }
    }
    public class WalletModel
    {
        public string Name
        {
            get;
            set;
        }
    }
}