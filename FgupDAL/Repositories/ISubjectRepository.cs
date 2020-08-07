using FgupDAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FgupDAL.Repositories
{
    public interface ISubjectRepository
    {
        Task<List<Subject>> GetAllSubjectsAsync();
        Task<List<Subject>> GetSubjectsByIdsAsync(List<long> subjectIds);
    }
}
