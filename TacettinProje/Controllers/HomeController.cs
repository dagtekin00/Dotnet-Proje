using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TacettinProje.Models;

namespace TacettinProje.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext context;

    public HomeController(AppDbContext context)
    {
        this.context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

     public IActionResult Sepetim()
    {
        return View();
    }

      public IActionResult Yatirim()
    {
        return View();
    }

    public IActionResult siparisSayfasi()
    {
        return View();
    }
    [HttpPost]
    public IActionResult siparisSayfasi(gelenSiparis gelenSiparis)
    {
        context.siparisler.Add(gelenSiparis);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult siparisVerenler()
    {
        return View(context.siparisler.ToList());
    }
    public IActionResult sil(int id)
    {
        gelenSiparis gelenSiparis = context.siparisler.FirstOrDefault(x => x.ID == id);
        context.siparisler.Remove(gelenSiparis);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult detay(int id)
    {
        gelenSiparis gelenSiparis = context.siparisler.FirstOrDefault(x => x.ID == id);
        return View(gelenSiparis);
    }
    public IActionResult guncelle(int id)
    {
        gelenSiparis gelenSiparis = context.siparisler.FirstOrDefault(x => x.ID == id);
        return View(gelenSiparis);
    }
    [HttpPost]
    public IActionResult guncelle(gelenSiparis gelenSiparis)
    {
        context.siparisler.Update(gelenSiparis);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
