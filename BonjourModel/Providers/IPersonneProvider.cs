using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonjourModel.Providers
{
    public interface IPersonneProvider
    {
        Task<IEnumerable<Personne>> GetAllAsync();
        Task<bool> AddOneAsync(Personne personne);
    }
}
