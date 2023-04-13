using Generic_F1.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_F1.Repository
{
    public interface IReadRepo<out TRRepo> where TRRepo : class, IPerson
    {
        IEnumerable<TRRepo> GetAll();
        TRRepo GetById(int id);
    }
}
