﻿namespace Application.Models
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    public class PaymentPostRequest
    {
        public Guid MerchantId { get; set; }
        public string CardNumber { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
        public int SecurityCode { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}