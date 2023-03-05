using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_mua_bán_xe_hơi
{
    internal interface ISellPerson
    {
        string nameSell { get; set; }
        string idSell { get; set; }
        int ageSell { get; set; }
        string levelSell { get; set; }
        void InfomationSell();
    }
}
