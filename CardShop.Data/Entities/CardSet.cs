using System.Numerics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CardShop.Data.Entities
{
    public class CardSet
    {
        public int Id { get; set; }
        public string BrandName { get; set; } = null!;
        public string SetName { get; set; } = null!;
        public int Year { get; set; }
        public string Format { get; set; } = null!;
        public int QuantityAvailable { get; set; } = 0;
        public int QuantityPurchased { get; set; } = 0;
        public double Value { get; set; } = 0;
        public double PurchasePrice { get; set; } = 0;
        public double SalePrice { get; set; } = 0;
        public string? Comments { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; } = null!;

        public double GrandTotal
        {
            get
            {
                return QuantityAvailable * Value;
            }
        }

        public double ProfitLossTotal
        {
            get
            {
                if (QuantityAvailable == QuantityPurchased)
                    return 0;
                else
                    return ((SalePrice * (QuantityPurchased - QuantityAvailable)) - ((QuantityPurchased - QuantityAvailable) * PurchasePrice));
            }
        }

    }
}