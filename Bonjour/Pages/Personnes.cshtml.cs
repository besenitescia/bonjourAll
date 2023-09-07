using Bonjour.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bonjour.Pages
{
    public class PersonnesModel : PageModel
    {
        [Inject]
        public PersonneViewModel pViewModel { get; set; }
        public async void OnGet()
        {
            await pViewModel.LoadData();
        }
    }
}
