using Microsoft.AspNetCore.Mvc.RazorPages;
using ALFASOFT.Models;

namespace ALFASOFT.Views.ContatoViews
{
    public class Details : PageModel
    {
        public Contato contato = new Contato();
        public void OnGet() { }
        public void OnPost() { }

    }
}
