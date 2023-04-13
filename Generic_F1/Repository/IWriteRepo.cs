using Generic_F1.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_F1.Repository
{
    public interface IWriteRepo<in TWRepo> where TWRepo : class,IPerson
    {
        void Add(TWRepo recer);

        void Remove(TWRepo recer);

        void Save();
    }
}
