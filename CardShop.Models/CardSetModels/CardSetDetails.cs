using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardShop.Models.CategoryModels;

namespace CardShop.Models.CardSetModels
{
    public class CardSetDetails
    {
        public int Id { get; set; }
        public string BrandName { get; set; } = null!;
        public string SetName { get; set; } = null!;
        public int Year { get; set; }
        public string Format { get; set; } = null!;
        public int QuantityAvailable { get; set; }
        public int QuantityPurchased { get; set; }
        public double Value { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public string? Comments { get; set; }
        public int CategoryId { get; set; }
        public CategoryListItem Category { get; set; } = null!;

        public double GrandTotal { get; set; }
        public double ProfitLossTotal { get; set; }
    }
}