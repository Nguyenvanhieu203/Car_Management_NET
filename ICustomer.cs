using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_mua_bán_xe_hơi
{
    internal interface ICustomer
    {
        string nameCustomer { get; set; }
        int idCustomer { get; set; }
        string addressCus { get; set; }
        int CusChoseCar { get; set; }
        void InformationCus();
        void inputCus();
        void outputCus();
        void outputCusVis();
    }
}
