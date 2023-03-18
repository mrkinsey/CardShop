using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CardShop.Data.Context;
using CardShop.Data.Entities;
using CardShop.Models.CardSetModels;
using Microsoft.EntityFrameworkCore;

namespace CardShop.Services.CardSetServices
{
    public class CardSetService : ICardSetService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public CardSetService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateCardSet(CardSetCreate model)
        {
            var cardSet = _mapper.Map<CardSet>(model);
            await _context.CardSets.AddAsync(cardSet);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteCardSet(int cardSetId)
        {
            var cardSet = await _context.CardSets.FindAsync(cardSetId);

            if (cardSet is null) return false;
            else
            {
                _context.CardSets.Remove(cardSet);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<CardSetDetails> GetCardSetById(int cardSetId)
        {
            var cardSet = await _context.CardSets.Include(n => n.Category).FirstOrDefaultAsync(x => x.Id == cardSetId);
            if (cardSet is null) return new CardSetDetails();

            return _mapper.Map<CardSetDetails>(cardSet);
        }

        public async Task<List<CardSetListItem>> GetCardSets()
        {
            var conversion = await _context.CardSets.Include(n => n.Category).ToListAsync();
            return _mapper.Map<List<CardSetListItem>>(conversion);
        }

        public async Task<bool> UpdateCardSet(CardSetUpdate model)
        {
            var cardSet = await _context.CardSets.FindAsync(model.Id);
            if (cardSet == null) return false;
            else
            {
                _mapper.Map(model, cardSet);
                await _context.SaveChangesAsync();
                return true;
            }
        }
    }
}