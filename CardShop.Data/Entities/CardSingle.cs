using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CardShop.Data.Entities
{
    public class CardSingle
    {
        public int Id { get; set; }
        public string CardName { get; set; } = null!;
        public string Parallel { get; set; } = null!;
        public int Year { get; set; }
        public int QuantityAvailable { get; set; } = 0;
        public int QuantityPurchased { get; set; } = 0;
        public double Value { get; set; } = 0;
        public double PurchasePrice { get; set; } = 0;
        public double SalePrice { get; set; } = 0;
        public string? Comments { get; set; }
        public int CardSetId { get; set; }

        [ForeignKey(nameof(CardSetId))]
        public virtual CardSet CardSet { get; set; } = null!;
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
                    return (SalePrice - ((QuantityPurchased - QuantityAvailable) * PurchasePrice));
            }
        }
    }
}