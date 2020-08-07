using FgupDAL.Context.Implementation;
using FgupDAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FgupDAL.Repositories.Implementation
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly TestDbContext _context;
        public SubjectRepository(TestDbContext context)
        {
            _context = context;
        }

        public async Task<List<Subject>> GetAllSubjectsAsync() => await _context.Subjects.ToListAsync();

        public async Task<List<Subject>> GetSubjectsByIdsAsync(List<long> subjectIds) => 
            await _context.Subjects.Where(x => subjectIds.Contains(x.Id)).ToListAsync();
    }
}
