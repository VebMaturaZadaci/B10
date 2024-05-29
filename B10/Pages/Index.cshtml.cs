using B10.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Reflection.Metadata;

namespace B10.Pages
{
    public class IndexModel : PageModel
    {
        public string srp;
        public string eng;
        public string op;

        private readonly RecnikService _service;
        public IndexModel(RecnikService service)
        {
            _service = service;
        }
        [BindProperty]
        public string Engleski { get; set; }

        [BindProperty]
        public string Srpski { get; set; }

        [BindProperty]
        public string Opis { get; set; }

        [BindProperty]
        public string Smer { get; set; }

        public void OnPost()
        {
            Prevod prevod;
            if(Smer == "0")
            {
                prevod = _service.PrevediEngleski(Engleski);
            }
            else
            {
                prevod = _service.PrevediSrpski(Srpski);
            }

            if(prevod != null)
            {
                srp = prevod.Srpski;
                eng = prevod.Engleski;
                op = prevod.Opis;
                Console.WriteLine(op);

                RedirectToPage("/Index");
            }
        }
    }
}
