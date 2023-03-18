using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardShop.Models.CardSetModels;

namespace CardShop.Services.CardSetServices
{
    public interface ICardSetService
    {
        Task<bool> CreateCardSet(CardSetCreate model);
        Task<List<CardSetListItem>> GetCardSets();
        Task<CardSetDetails> GetCardSetById(int cardSetId);
        Task<bool> UpdateCardSet(CardSetUpdate model);
        Task<bool> DeleteCardSet(int cardSetId);
    }
}