using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonjourModel.Providers
{
    public class PersonneProvider : IPersonneProvider
    {
        public MydatabaseContext _context;

        public PersonneProvider(MydatabaseContext context)
        {
            _context = context;
        }
        public async Task<bool> AddOneAsync(Personne personne)
        {
            var pers = await _context.personnes.AddAsync(personne);
            if (pers.Entity.Id != 0) return true;
            return false;
        }

        public async Task<IEnumerable<Personne>> GetAllAsync()
        {
            return _context.personnes;
        }
    }
}
