using BonjourModel;

namespace Bonjour.Services
{
    public interface IPersonneService 
    {
        Task<IEnumerable<Personne>> GetAll();
        Task<bool> AddOne(Personne personne);

    }
}
