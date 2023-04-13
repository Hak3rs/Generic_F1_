using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_F1.Team
{
    public class RacerTests : Racer 
    {
        public override string ToString()
        {
            return "(Racer Tests)" + base.ToString();
        }
    }
}
