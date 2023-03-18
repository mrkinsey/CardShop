using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardShop.Models.CardSetModels
{
    public class CardSetCreate
    {
        [Required]
        public string BrandName { get; set; } = null!;

        [Required]
        public string SetName { get; set; } = null!;

        [Required]
        public int Year { get; set; }

        [Required]
        public string Format { get; set; } = null!;

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
        public int CategoryId { get; set; }
    }
}