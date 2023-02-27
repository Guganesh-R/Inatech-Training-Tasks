﻿using System;
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
    public class MembershipFeeController : Controller
    {
        private readonly CoreMvcContext _context;

        public MembershipFeeController(CoreMvcContext context)
        {
            _context = context;
        }

        // GET: MembershipFee
        public async Task<IActionResult> Index()
        {
              return View(await _context.MembershipFee.ToListAsync());
        }

        // GET: MembershipFee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MembershipFee == null)
            {
                return NotFound();
            }

            var membershipFee = await _context.MembershipFee
                .FirstOrDefaultAsync(m => m.MembershipType == id);
            if (membershipFee == null)
            {
                return NotFound();
            }

            return View(membershipFee);
        }

        // GET: MembershipFee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MembershipFee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MembershipType,MembershipName,Fee")] MembershipFee membershipFee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(membershipFee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(membershipFee);
        }

        // GET: MembershipFee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MembershipFee == null)
            {
                return NotFound();
            }

            var membershipFee = await _context.MembershipFee.FindAsync(id);
            if (membershipFee == null)
            {
                return NotFound();
            }
            return View(membershipFee);
        }

        // POST: MembershipFee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MembershipType,MembershipName,Fee")] MembershipFee membershipFee)
        {
            if (id != membershipFee.MembershipType)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(membershipFee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MembershipFeeExists(membershipFee.MembershipType))
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
            return View(membershipFee);
        }

        // GET: MembershipFee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MembershipFee == null)
            {
                return NotFound();
            }

            var membershipFee = await _context.MembershipFee
                .FirstOrDefaultAsync(m => m.MembershipType == id);
            if (membershipFee == null)
            {
                return NotFound();
            }

            return View(membershipFee);
        }

        // POST: MembershipFee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MembershipFee == null)
            {
                return Problem("Entity set 'CoreMvcContext.MembershipFee'  is null.");
            }
            var membershipFee = await _context.MembershipFee.FindAsync(id);
            if (membershipFee != null)
            {
                _context.MembershipFee.Remove(membershipFee);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MembershipFeeExists(int id)
        {
          return _context.MembershipFee.Any(e => e.MembershipType == id);
        }
    }
}
