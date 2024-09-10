using Microsoft.AspNetCore.Mvc.RazorPages;
using ZodiacAnimals.Models;
using Microsoft.AspNetCore.Mvc;

namespace ZodiacAnimals.Pages
{
    public class ZodiacModel : PageModel
    {
        [BindProperty]
        public int ZodiacYear { get; set; }

        public void OnGet()
        {
            ViewData["Zodiac"] = "";
        }

        public void OnPost() {
            ViewData["Zodiac"] = Zodiac.GetZodiac(ZodiacYear);
            if (ViewData["Zodiac"] as string == "-1") {
                ViewData["Zodiac"] = "Invalid year. The year must be between 1900 and next year to the current year.";
            }
        }
    }
}
