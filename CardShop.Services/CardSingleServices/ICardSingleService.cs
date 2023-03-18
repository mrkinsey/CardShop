using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardShop.Models.CardSingleModels;

namespace CardShop.Services.CardSingleServices
{
    public interface ICardSingleService
    {
        Task<bool> CreateCardSingle(CardSingleCreate model);
        Task<List<CardSingleListItem>> GetCardSingles();
        Task<CardSingleDetails> GetCardSingleById(int cardSingleId);
        Task<bool> UpdateCardSingle(CardSingleUpdate model);
        Task<bool> DeleteCardSingle(int cardSingleId);
    }
}