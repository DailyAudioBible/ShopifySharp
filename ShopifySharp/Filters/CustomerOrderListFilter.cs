using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class CustomerOrderListFilter : Parameterizable
    {
        /// <summary>
        /// Restricts results to those with the given status. Known values are "open", "closed", "cancelled" and "any".
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}