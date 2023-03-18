using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardShop.Models.CardSingleModels
{
    public class CardSingleCreate
    {
        [Required]
        public string CardName { get; set; } = null!;

        [Required]
        public string Parallel { get; set; } = null!;

        [Required]
        public int Year { get; set; }

        [Required]
        public int QuantityAvailable { get; set; } = 0;

        [Required]
        public int QuantityPurchased { get; set; } = 0;

        [Required]
        public double Value { get; set; } = 0;

        [Required]
        public double PurchasePrice { get; set; } = 0;

        [Required]
        public double SalePrice { get; set; } = 0;

        public string? Comments { get; set; }

        [Required]
        public int CardSetId { get; set; }
    }
}