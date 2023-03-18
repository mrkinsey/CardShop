using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardShop.Models.CardSingleModels
{
    public class CardSingleListItem
    {
        public int Id { get; set; }
        public string CardName { get; set; } = null!;
        public string Parallel { get; set; } = null!;
        public int Year { get; set; }
        public double GrandTotal { get; set; }
        public double ProfitLossTotal { get; set; }
    }
}