﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/orderlookupresponse
    public class OrderLookupResponse
    {
        public OrderLookupStatus OrderLookupStatus { get; set; }
        /// <summary>
        /// JWSTransaction
        /// </summary>
        public List<string> SignedTransactions { get; set; } = new();
    }
}
