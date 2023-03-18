using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CardShop.Data.Context;
using CardShop.Data.Entities;
using CardShop.Models.CardSingleModels;
using Microsoft.EntityFrameworkCore;

namespace CardShop.Services.CardSingleServices
{
    public class CardSingleService : ICardSingleService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public CardSingleService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateCardSingle(CardSingleCreate model)
        {
            var cardSingle = _mapper.Map<CardSingle>(model);
            await _context.CardSingles.AddAsync(cardSingle);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteCardSingle(int cardSingleId)
        {
            var cardSingle = await _context.CardSingles.FindAsync(cardSingleId);

            if (cardSingle == null) return false;
            else
            {
                _context.CardSingles.Remove(cardSingle);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<CardSingleDetails> GetCardSingleById(int cardSingleId)
        {
            var cardSingle = await _context.CardSingles.FindAsync(cardSingleId);
            if (cardSingle is null) return new CardSingleDetails();

            return _mapper.Map<CardSingleDetails>(cardSingle);
        }

        public async Task<List<CardSingleListItem>> GetCardSingles()
        {
            var conversion = await _context.CardSingles.ToListAsync();
            return _mapper.Map<List<CardSingleListItem>>(conversion);
        }

        public async Task<bool> UpdateCardSingle(CardSingleUpdate model)
        {
            var cardSingle = await _context.CardSingles.FindAsync(model.Id);
            if (cardSingle == null) return false;
            else
            {
                _mapper.Map(model, cardSingle);
                await _context.SaveChangesAsync();
                return true;
            }
        }
    }
}