using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreMvc.Data;
using CoreMvc.Models;

namespace CoreMvc.Controllers
{
    public class MembershipDetailController : Controller
    {
        private readonly CoreMvcContext _context;

        public MembershipDetailController(CoreMvcContext context)
        {
            _context = context;
        }

        // GET: MembershipDetail
        public async Task<IActionResult> Index()
        {
            var coreMvcContext = _context.MembershipDetail.Include(m => m.Customer).Include(m => m.MembershipFee);
            return View(await coreMvcContext.ToListAsync());
        }

        // GET: MembershipDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MembershipDetail == null)
            {
                return NotFound();
            }

            var membershipDetail = await _context.MembershipDetail
                .Include(m => m.Customer)
                .Include(m => m.MembershipFee)
                .FirstOrDefaultAsync(m => m.MembershipId == id);
            if (membershipDetail == null)
            {
                return NotFound();
            }

            return View(membershipDetail);
        }

        // GET: MembershipDetail/Create
        public IActionResult Create()
        {
            ViewData["CustmID"] = new SelectList(_context.Customer, "CustID", "CustID");
            ViewData["MembType"] = new SelectList(_context.MembershipFee, "MembershipType", "MembershipType");
            return View();
        }

        // POST: MembershipDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MembershipId,CustmID,MembType")] MembershipDetail membershipDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(membershipDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustmID"] = new SelectList(_context.Customer, "CustID", "CustID", membershipDetail.CustmID);
            ViewData["MembType"] = new SelectList(_context.MembershipFee, "MembershipType", "MembershipType", membershipDetail.MembershipType);
            return View(membershipDetail);
        }

        // GET: MembershipDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MembershipDetail == null)
            {
                return NotFound();
            }

            var membershipDetail = await _context.MembershipDetail.FindAsync(id);
            if (membershipDetail == null)
            {
                return NotFound();
            }
            ViewData["CustmID"] = new SelectList(_context.Customer, "CustID", "CustID", membershipDetail.CustmID);
            ViewData["MembType"] = new SelectList(_context.MembershipFee, "MembershipType", "MembershipType", membershipDetail.MembershipType);
            return View(membershipDetail);
        }

        // POST: MembershipDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MembershipId,CustmID,MembType")] MembershipDetail membershipDetail)
        {
            if (id != membershipDetail.MembershipId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(membershipDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MembershipDetailExists(membershipDetail.MembershipId))
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
            ViewData["CustmID"] = new SelectList(_context.Customer, "CustID", "CustID", membershipDetail.CustmID);
            ViewData["MembType"] = new SelectList(_context.MembershipFee, "MembershipType", "MembershipType", membershipDetail.MembershipType);
            return View(membershipDetail);
        }

        // GET: MembershipDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MembershipDetail == null)
            {
                return NotFound();
            }

            var membershipDetail = await _context.MembershipDetail
                .Include(m => m.Customer)
                .Include(m => m.MembershipFee)
                .FirstOrDefaultAsync(m => m.MembershipId == id);
            if (membershipDetail == null)
            {
                return NotFound();
            }

            return View(membershipDetail);
        }

        // POST: MembershipDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MembershipDetail == null)
            {
                return Problem("Entity set 'CoreMvcContext.MembershipDetail'  is null.");
            }
            var membershipDetail = await _context.MembershipDetail.FindAsync(id);
            if (membershipDetail != null)
            {
                _context.MembershipDetail.Remove(membershipDetail);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MembershipDetailExists(int id)
        {
          return _context.MembershipDetail.Any(e => e.MembershipId == id);
        }
    }
}
