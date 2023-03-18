using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardShop.Models.CardSetModels
{
    public class CardSetListItem
    {
        public int Id { get; set; }
        public string BrandName { get; set; } = null!;
        public string SetName { get; set; } = null!;
        public int Year { get; set; }
        public string Format { get; set; } = null!;
        public double GrandTotal { get; set; }
        public double ProfitLossTotal { get; set; }
    }
}