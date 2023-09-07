using Bonjour.Services;
using BonjourModel;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Bonjour.ViewModels
{
    public class PersonneViewModel
    {
        private readonly IPersonneService _personneService;
        public List<Personne> personnes { get; set; }
        public PersonneViewModel(IPersonneService personneService)
        {
            _personneService = personneService;
        }

        public async Task LoadData()
        {
            personnes = (await _personneService.GetAll()).OrderBy(x => x.lastname).ToList();
        }

        public async Task<bool> AddItem(string firstname, string lastname, string birthdate)
        {
            bool result = false;
            try
            {
                bool test = DateTime.TryParse(birthdate, out DateTime bdate);
                
                var today = DateTime.Today;

                // Calculate the age.
                var age = today.Year - bdate.Year;

                // Go back to the year in which the person was born in case of a leap year
                if (bdate.Date > today.AddYears(-age)) age--;

                if (age > 150) throw new Exception("trop vieux"); 

                Personne personne = new Personne()
                {
                    firstname = firstname,
                    lastname = lastname,
                    birthdate = bdate
                };
                result = await _personneService.AddOne(personne);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
