using Bonjour.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bonjour.Pages
{
    public class AjouterPersonneModel : PageModel
    {
        [Inject]
        public PersonneViewModel pViewModel { get; set; }
        public void OnGet()
        {
        }

        public async void OnPost() {
            string nom = Request.Form["nom"];
            string prenom = Request.Form["prenom"];
            string birthdate = Request.Form["birthdate"];

            bool result = await pViewModel.AddItem(nom,prenom,birthdate);

            if (result) Redirect("/personnes");
        }
    }
}
