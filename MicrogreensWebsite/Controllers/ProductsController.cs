using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MicrogreensWebsite.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace MicrogreensWebsite.Controllers
{
 
    
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;
      

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        /* Authorizing employee and Admin to only do this task from the products controller and 
         the farmer will not be able to use it*/
        [Authorize(Roles="Employee,Admin")]
        public async Task<IActionResult> EmployeeProductView(string farmerSearch, string sorting)
        {
            var appDbContext = from f in _context.Product.Include(p => p.Category).Include(p => p.Farmer)
                               select f;

            ViewBag.CategorySort = String.IsNullOrEmpty(sorting) ? "CategoryNameDesc" : "";
            if (!String.IsNullOrEmpty(farmerSearch))
            {
                appDbContext = appDbContext.Where(f => f.Farmer.FarmerName.Contains(farmerSearch));
            }
            
                if (sorting == "CategoryNameDesc")
                {
                    appDbContext = appDbContext.OrderByDescending(b => b.Category.CategoryName);
                }
                else
                {
                    appDbContext = appDbContext.OrderBy(b => b.Category.CategoryName);
                }

            return View(await appDbContext.ToListAsync());
        }
        /* Authorizing Farmer and Admin to only do this task from the products controller and 
        the employee will not be able to use it*/
        [Authorize(Roles = "Farmer, Admin")]
        // GET: Products
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Product.Include(p => p.Category).Include(p => p.Farmer);
           

            return View(await appDbContext.ToListAsync());
  
           
        }
        /* Authorizing Farmer and Admin to only do this task from the products controller and 
       the employee will not be able to use it*/
        [Authorize(Roles = "Farmer, Admin")]
        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .Include(p => p.Farmer)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [Authorize(Roles = "Employee, Admin")]
        public async Task<IActionResult> Detail2(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .Include(p => p.Farmer)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        /* Authorizing Farmer and Admin to only do this task from the products controller and 
       the employee will not be able to use it*/
        [Authorize(Roles = "Farmer, Admin")]
        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryID");
            ViewData["FarmerID"] = new SelectList(_context.Farmer, "FarmerID", "FarmerID");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        /* Authorizing Farmer and Admin to only do this task from the products controller and 
       the employee will not be able to use it*/
        [Authorize(Roles ="Farmer, Admin")]
        [HttpPost]
        
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,ProductName,ProductDescription,ProductImage,ProductSuppliedDate,FarmerID,CategoryID,Quantity,Price,IsInStock,IsOnSale")] Product product)
        {
            if (ModelState.IsValid)
            {
               
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryID", product.CategoryID);
            ViewData["FarmerID"] = new SelectList(_context.Farmer, "FarmerID", "FarmerID", product.FarmerID);
            return View(product);
        }


        /* Authorizing Farmer and Admin to only do this task from the products controller and 
       the employee will not be able to use it*/
        [Authorize(Roles = "Farmer, Admin")]
        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryID", product.CategoryID);
            ViewData["FarmerID"] = new SelectList(_context.Farmer, "FarmerID", "FarmerID", product.FarmerID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        /* Authorizing Farmer and Admin to only do this task from the products controller and 
       the employee will not be able to use it*/
        [Authorize(Roles = "Farmer, Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("ProductID,ProductName,ProductDescription,ProductImage,ProductSuppliedDate,FarmerID,CategoryID,Quantity,Price,IsInStock,IsOnSale")] Product product)
        {
            
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryID", product.CategoryID);
            ViewData["FarmerID"] = new SelectList(_context.Farmer, "FarmerID", "FarmerID", product.FarmerID);
            return View(product);
        }
        /* Authorizing Farmer and Admin to only do this task from the products controller and 
       the employee will not be able to use it*/
        [Authorize(Roles = "Farmer, Admin")]
        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .Include(p => p.Farmer)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        /* Authorizing Farmer and Admin to only do this task from the products controller and 
       the employee will not be able to use it*/
        [Authorize(Roles = "Farmer, Admin")]
        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        /* Authorizing Farmer and Admin to only do this task from the products controller and 
       the employee will not be able to use it*/
        [Authorize(Roles = "Farmer, Admin")]
        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductID == id);
        }
    }
}
