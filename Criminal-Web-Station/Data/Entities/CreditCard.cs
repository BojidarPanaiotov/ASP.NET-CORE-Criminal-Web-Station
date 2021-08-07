﻿namespace Criminal_Web_Station.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CreditCard
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();
        [Required]
        public string Number { get; init; }
        [Required]
        public int Cvv { get; init; }

        [Required]
        public DateTime ExpiredOn { get; set; }
        [Required]
        public decimal Balance { get; set; }
        public string AccountId { get; init; }
        [Required]
        public Account Account { get; init; }
    }
}
