using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VehicleInsurance.Data;

namespace VehicleInsurance.Models
{
    public class btnsController : Controller
    {
        private readonly VehicleInsuranceContext _context;

        public btnsController(VehicleInsuranceContext context)
        {
            _context = context;
        }

        // GET: btns
        public async Task<IActionResult> Index()
        {
            return View(await _context.btn.ToListAsync());
        }

        // GET: btns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var btn = await _context.btn
                .FirstOrDefaultAsync(m => m.Id == id);
            if (btn == null)
            {
                return NotFound();
            }

            return View(btn);
        }

        // GET: btns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: btns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LoaiXe,MucDichSuDung,SoChoNgoi,ThoiGianBaoHiem,NgayBatDau,GioBatDau,NgayKetThuc,GioKetThuc,MaGioiThieu,DongY")] btn btn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(btn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(btn);
        }

        // GET: btns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var btn = await _context.btn.FindAsync(id);
            if (btn == null)
            {
                return NotFound();
            }
            return View(btn);
        }

        // POST: btns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LoaiXe,MucDichSuDung,SoChoNgoi,ThoiGianBaoHiem,NgayBatDau,GioBatDau,NgayKetThuc,GioKetThuc,MaGioiThieu,DongY")] btn btn)
        {
            if (id != btn.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(btn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!btnExists(btn.Id))
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
            return View(btn);
        }

        // GET: btns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var btn = await _context.btn
                .FirstOrDefaultAsync(m => m.Id == id);
            if (btn == null)
            {
                return NotFound();
            }

            return View(btn);
        }

        // POST: btns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var btn = await _context.btn.FindAsync(id);
            if (btn != null)
            {
                _context.btn.Remove(btn);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool btnExists(int id)
        {
            return _context.btn.Any(e => e.Id == id);
        }
    }
}
