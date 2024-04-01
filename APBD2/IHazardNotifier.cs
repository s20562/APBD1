using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD2
{
    public interface IHazardNotifier
    {
        void Notify(string numerSeryjny);
    }
}
