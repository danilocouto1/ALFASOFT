using ALFASOFT.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ALFASOFT.Views.ContatoViews
{
    public class Index : PageModel
    {
        public Contato contato = new Contato();
        public void OnGet() { }
        public void OnPost() { }

    }
}
