using Flyhigh.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyhigh.Desktop.Service
{
    public interface IGepService
    {
        public Task<List<GepAdatok>> SelectAllGep();
    }
}

