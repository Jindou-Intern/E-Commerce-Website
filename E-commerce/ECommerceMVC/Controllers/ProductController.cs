using AutoMapper;
using ECommerceMVC.Data;
using ECommerceMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceMVC.Controllers
{
  
    public class ProductController : Controller
    {
        private readonly Hshop2023Context _context;
        public ProductController(Hshop2023Context context)
        {
            
            _context = context;
        }
        public async Task<IActionResult> AllProducts()
        {
            var model = await _context.HangHoas.Select(h => new HangHoaVM
            {
                MaHh = h.MaHh,
                TenHh = h.TenHh,
                Hinh = h.Hinh,
                MoTaDonVi = h.MoTaDonVi,
                DonGia = h.DonGia
            }).ToListAsync();

            return View(model);
        }

    }
}
