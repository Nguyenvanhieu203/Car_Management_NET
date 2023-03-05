using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_mua_bán_xe_hơi
{
    internal interface ICar
    {
        string modelCar { get; set; }
        int yearCar { get; set; }
        float priceCar { get; set; }
        void InformationCar();

        void inputCar();
        void outputCar();
    }
}
