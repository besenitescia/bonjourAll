using BonjourModel;
using BonjourModel.Providers;

namespace Bonjour.Services
{
    public class PersonneService : IPersonneService
    {
        private readonly IPersonneProvider _personneProvider;

        public PersonneService(IPersonneProvider personneProvider)
        {

            _personneProvider = personneProvider;

        }
        public async Task<IEnumerable<Personne>> GetAll()
        {
            return await _personneProvider.GetAllAsync();
        }

        public async Task<bool> AddOne(Personne personne)
        {
            return await _personneProvider.AddOneAsync(personne);
        }
    }
}
