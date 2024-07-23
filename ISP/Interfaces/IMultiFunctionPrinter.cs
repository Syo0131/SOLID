using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Interfaces
{
    public interface IMultiFunctionPrinter : ISimplePrinter
    {
        public void scan();
    }
}
