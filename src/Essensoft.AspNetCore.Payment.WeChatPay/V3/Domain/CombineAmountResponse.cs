﻿using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 合单下单订单金额信息
    /// </summary>    
    public class CombineAmountResponse : WeChatPayObject
    {
        /// <summary>
        /// 标价金额
        /// 子单金额，单位为分
        /// 境外场景下，标价金额要超过商户结算币种的最小单位金额，例如结算币种为美元，则标价金额必须大于1美分
        /// 示例值：100
        /// </summary>
        [JsonPropertyName("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 标价币种	
        /// 符合ISO 4217标准的三位字母代码，人民币：CNY 。
        /// 示例值：CNY
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 现金支付金额
        /// 订单现金支付金额。
        /// 示例值： 10
        /// </summary>
        [JsonPropertyName("payer_amount")]
        public int PayerAmount { get; set; }

        /// <summary>
        /// 现金支付币种	
        /// 货币类型，符合ISO 4217标准的三位字母代码，默认人民币：CNY。
        /// 示例值： CNY
        /// </summary>
        [JsonPropertyName("payer_currency")]
        public string PayerCurrency { get; set; }
    }
}
