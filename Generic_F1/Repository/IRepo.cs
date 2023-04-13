using Generic_F1.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_F1.Repository
{
    internal interface IRepo<TRepo> : IWriteRepo<TRepo>, IReadRepo<TRepo> where TRepo : class, IPerson
    {
    }
}
