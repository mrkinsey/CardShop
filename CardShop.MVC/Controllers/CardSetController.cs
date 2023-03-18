using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardShop.Models.CardSetModels;
using CardShop.Services.CardSetServices;
using Microsoft.AspNetCore.Mvc;

namespace CardShop.MVC.Controllers
{
    public class CardSetController : Controller
    {
        private ICardSetService _cardSetService;

        public CardSetController(ICardSetService cardSetService)
        {
            _cardSetService = cardSetService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _cardSetService.GetCardSets());
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            return View(await _cardSetService.GetCardSetById(id));
        }

        [HttpGet]
        public async Task<IActionResult> Post()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Post(CardSetCreate model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (await _cardSetService.CreateCardSet(model))
                return RedirectToAction(nameof(Index));
            else
                return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var cardSet = await _cardSetService.GetCardSetById(id);
            var cardSetUpdate = new CardSetUpdate
            {
                Id = cardSet.Id,
                BrandName = cardSet.BrandName,
                SetName = cardSet.SetName,
                Year = cardSet.Year,
                Format = cardSet.Format,
                QuantityAvailable = cardSet.QuantityAvailable,
                QuantityPurchased = cardSet.QuantityPurchased,
                Value = cardSet.Value,
                PurchasePrice = cardSet.PurchasePrice,
                SalePrice = cardSet.SalePrice,
                Comments = cardSet.Comments,
                CategoryId = cardSet.CategoryId
            };
            return View(cardSetUpdate);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CardSetUpdate model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (await _cardSetService.UpdateCardSet(model))
                return RedirectToAction(nameof(Index));
            else
                return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var cardSet = await _cardSetService.GetCardSetById(id);
            return View(cardSet);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            var isSuccessful = await _cardSetService.DeleteCardSet(id.Value);
            if (isSuccessful)
                return RedirectToAction(nameof(Index));
            else
                return UnprocessableEntity();
        }
    }
}