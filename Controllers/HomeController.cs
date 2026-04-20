using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SanalTarihcim.Models;

namespace SanalTarihcim.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    [Route("giris")]
    public IActionResult Giris() => View();

    [Route("uye-ol")]
    public IActionResult UyeOl() => View();

    [Route("sepetim")]
    public IActionResult Sepetim() => View();

    [Route("sepetonay")]
    public IActionResult Sepetonay() => View();

    [Route("turk-tarihciler")]
    public IActionResult TurkTarihciler() => View();

    [Route("alman-tarihciler")]
    public IActionResult AlmanTarihciler() => View();

    [Route("fransiz-tarihciler")]
    public IActionResult FransizTarihciler() => View();

    [Route("ingiliz-tarihciler")]
    public IActionResult IngilizTarihciler() => View();

    [Route("amerikan-tarihciler")]
    public IActionResult AmerikanTarihciler() => View();

    [Route("arap-tarihciler")]
    public IActionResult ArapTarihciler() => View();

    [Route("misir-tarihciler")]
    public IActionResult MisirTarihciler() => View();

    [Route("yunan-tarihciler")]
    public IActionResult YunanTarihciler() => View();

    [Route("osmanli")]
    public IActionResult Osmanli() => View();

    [Route("roma")]
    public IActionResult Roma() => View();

    [Route("eski-cag")]
    public IActionResult EskiCag() => View();

    [Route("orta-cag")]
    public IActionResult OrtaCag() => View();

    [Route("yeni-cag")]
    public IActionResult YeniCag() => View();

    [Route("modern-tarih")]
    public IActionResult ModernTarih() => View();

    [Route("islam-tarihi")]
    public IActionResult IslamTarihi() => View();

    [Route("avrupa-tarihi")]
    public IActionResult AvrupaTarihi() => View();

    [Route("dunya-tarihi")]
    public IActionResult DunyaTarihi() => View();

    [Route("savas-tarihi")]
    public IActionResult SavasTarihi() => View();

    [Route("fermanlar")]
    public IActionResult Fermanlar() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
