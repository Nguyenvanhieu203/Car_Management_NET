using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_mua_bán_xe_hơi
{
    internal class ListCar: ICar
    {
        public string modelCar
        {
            get;
            set;
        }
        public int yearCar
        {
            get;
            set;
        }
        public float priceCar
        {
            get;
            set;
        }
        public void InformationCar()
        {
                
        }

        public void inputCar()
        {
            Console.Write("Nhap ten xe: ");
            modelCar = Console.ReadLine();
            Console.Write("Nhap nam san xuat: ");
            yearCar = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia xe: ");
            priceCar = float.Parse(Console.ReadLine());
        }
        public void outputCar()
        {
            Console.WriteLine("Hang xe: {0}\nNam san xuat: {1}\nGia xe: {2}", modelCar.ToUpper(), yearCar, priceCar);
        }
    }
}
