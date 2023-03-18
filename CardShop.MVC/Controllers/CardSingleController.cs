using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardShop.Models.CardSingleModels;
using CardShop.Services.CardSingleServices;
using Microsoft.AspNetCore.Mvc;

namespace CardShop.MVC.Controllers
{
    public class CardSingleController : Controller
    {
        private ICardSingleService _cardSingleService;

        public CardSingleController(ICardSingleService cardSingleService)
        {
            _cardSingleService = cardSingleService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _cardSingleService.GetCardSingles());
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            return View(await _cardSingleService.GetCardSingleById(id));
        }

        [HttpGet]
        public async Task<IActionResult> Post()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Post(CardSingleCreate model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (await _cardSingleService.CreateCardSingle(model))
                return RedirectToAction(nameof(Index));
            else
                return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var cardSingle = await _cardSingleService.GetCardSingleById(id);
            var cardSetUpdate = new CardSingleUpdate
            {
                Id = cardSingle.Id,
                CardName = cardSingle.CardName,
                Parallel = cardSingle.Parallel,
                Year = cardSingle.Year,
                QuantityAvailable = cardSingle.QuantityAvailable,
                QuantityPurchased = cardSingle.QuantityPurchased,
                Value = cardSingle.Value,
                PurchasePrice = cardSingle.PurchasePrice,
                SalePrice = cardSingle.SalePrice,
                Comments = cardSingle.Comments,
                CardSetId = cardSingle.CardSetId,
            };
            return View(cardSetUpdate);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CardSingleUpdate model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (await _cardSingleService.UpdateCardSingle(model))
                return RedirectToAction(nameof(Index));
            else
                return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var cardSet = await _cardSingleService.GetCardSingleById(id);
            return View(cardSet);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            var isSuccessful = await _cardSingleService.DeleteCardSingle(id.Value);
            if (isSuccessful)
                return RedirectToAction(nameof(Index));
            else
                return UnprocessableEntity();
        }

    }
}