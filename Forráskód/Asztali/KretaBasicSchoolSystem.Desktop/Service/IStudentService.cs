using Flyhigh.Desktop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Flyhigh.Desktop.Service
{
    public interface IStudentService
    {
        public Task<List<Student>> SelectAllStudent();
    }
}
