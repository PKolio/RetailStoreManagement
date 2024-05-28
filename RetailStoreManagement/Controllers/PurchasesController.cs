using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetailStoreManagement.Data;
using RetailStoreManagement.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailStoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        private readonly RetailStoreContext _context;

        public PurchasesController(RetailStoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Purchase>>> GetPurchases()
        {
            return await _context.Purchases.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Purchase>> GetPurchase(int id)
        {
            var purchase = await _context.Purchases
                .FirstOrDefaultAsync(p => p.PurchaseId == id);

            if (purchase == null)
            {
                return NotFound();
            }

            return purchase;
        }

        [HttpPost]
        public async Task<ActionResult<Purchase>> PostPurchase(Purchase purchase)
        {
             _context.Purchases.Add(purchase);

            await _context.SaveChangesAsync();

            if (purchase == null)
            {
                return NotFound();
            }

            return purchase;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchase(int id, Purchase purchase)
        {
            if (id != purchase.PurchaseId)
            {
                return BadRequest();
            }

            _context.Entry(purchase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchase(int id)
        {
            var purchase = await _context.Purchases.FindAsync(id);
            if (purchase == null)
            {
                return NotFound();
            }

            _context.Purchases.Remove(purchase);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchaseExists(int id)
        {
            return _context.Purchases.Any(e => e.PurchaseId == id);
        }
    }
}
