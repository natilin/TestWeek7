using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TestWeek7.Data;
using TestWeek7.Models;

namespace TestWeek7.Controllers
{
    public class ProductsController : Controller
    {
        private readonly HttpClient _httpClient;

        public ProductsController(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("https://fakestoreapi.com/products");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<List<string>>(responseBody);

            return View(products);
        }


        //        // GET: Products/Details/5
        //        public async Task<IActionResult> Details(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return NotFound();
        //            }

        //            var product = await _httpClient.Product
        //                .FirstOrDefaultAsync(m => m.Id == id);
        //            if (product == null)
        //            {
        //                return NotFound();
        //            }

        //            return View(product);
        //        }

        //        // GET: Products/Create
        //        public IActionResult Create()
        //        {
        //            return View();
        //        }

        //        // POST: Products/Create
        //        // To protect from overposting attacks, enable the specific properties you want to bind to.
        //        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> Create([Bind("Id,titel,price,description,image,category")] Product product)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                _httpClient.Add(product);
        //                await _httpClient.SaveChangesAsync();
        //                return RedirectToAction(nameof(Index));
        //            }
        //            return View(product);
        //        }

        //        // GET: Products/Edit/5
        //        public async Task<IActionResult> Edit(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return NotFound();
        //            }

        //            var product = await _httpClient.Product.FindAsync(id);
        //            if (product == null)
        //            {
        //                return NotFound();
        //            }
        //            return View(product);
        //        }

        //        // POST: Products/Edit/5
        //        // To protect from overposting attacks, enable the specific properties you want to bind to.
        //        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> Edit(int? id, [Bind("Id,titel,price,description,image,category")] Product product)
        //        {
        //            if (id != product.Id)
        //            {
        //                return NotFound();
        //            }

        //            if (ModelState.IsValid)
        //            {
        //                try
        //                {
        //                    _httpClient.Update(product);
        //                    await _httpClient.SaveChangesAsync();
        //                }
        //                catch (DbUpdateConcurrencyException)
        //                {
        //                    if (!ProductExists(product.Id))
        //                    {
        //                        return NotFound();
        //                    }
        //                    else
        //                    {
        //                        throw;
        //                    }
        //                }
        //                return RedirectToAction(nameof(Index));
        //            }
        //            return View(product);
        //        }

        //        // GET: Products/Delete/5
        //        public async Task<IActionResult> Delete(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return NotFound();
        //            }

        //            var product = await _httpClient.Product
        //                .FirstOrDefaultAsync(m => m.Id == id);
        //            if (product == null)
        //            {
        //                return NotFound();
        //            }

        //            return View(product);
        //        }

        //        // POST: Products/Delete/5
        //        [HttpPost, ActionName("Delete")]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> DeleteConfirmed(int? id)
        //        {
        //            var product = await _httpClient.Product.FindAsync(id);
        //            if (product != null)
        //            {
        //                _httpClient.Product.Remove(product);
        //            }

        //            await _httpClient.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }

        //        private bool ProductExists(int? id)
        //        {
        //            return _httpClient.Product.Any(e => e.Id == id);
        //        }
    }
}
