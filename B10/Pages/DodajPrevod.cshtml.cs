using B10.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace B10.Pages
{
    public class DodajPrevodModel : PageModel
    {
        private readonly RecnikService _service;

        public DodajPrevodModel(RecnikService service)
        {
            _service = service;
        }


        [BindProperty, Required]
        public string Srpski { get; set; }
        [BindProperty, Required]
        public string Engleski { get; set; }
        [BindProperty, Required]
        public string Opis { get; set; }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                 var prevod = new Prevod { Srpski = Srpski, Engleski = Engleski, Opis = Opis };
                 _service.DodajPrevod(prevod);
                 RedirectToPage("/Index");
            }
        }
    }
}
