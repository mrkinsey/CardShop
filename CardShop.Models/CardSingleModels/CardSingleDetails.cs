using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardShop.Models.CardSetModels;

namespace CardShop.Models.CardSingleModels
{
    public class CardSingleDetails
    {
        public int Id { get; set; }
        public string CardName { get; set; } = null!;
        public string Parallel { get; set; } = null!;
        public int Year { get; set; }
        public int QuantityAvailable { get; set; }
        public int QuantityPurchased { get; set; }
        public double Value { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public int CardSetId { get; set; }
        public string? Comments { get; set; }
        public CardSetListItem CardSet { get; set; } = null!;
        public double GrandTotal { get; set; }
        public double ProfitLossTotal { get; set; }
    }
}