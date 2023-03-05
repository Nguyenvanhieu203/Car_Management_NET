using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ứng_dụng_mua_bán_xe_hơi
{
    internal class ListCus : ICustomer,ICar
    {
        // Thông tin khách hàng
        public string nameCustomer
        {
            get;
            set;
        }
        public int idCustomer
        {
            get;
            set;
        }
        public string addressCus
        {
            get;
            set;
        }
        public int CusChoseCar
        {
            get;
            set;
        }

        // Nhập thông tin xe
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

        public void inputCus()
        {
            Console.WriteLine("Nhap thong tin khach hang: ");
            Console.Write("Nhap ten khach hang: ");
            nameCustomer = Console.ReadLine();
            Console.Write("Nhap so CMND khach hang: ");
            idCustomer = int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi khach hang: ");
            addressCus = Console.ReadLine();
        }
        public void outputCus()
        {
            Console.WriteLine("Ten khach hang: {0}\nSo CMND: {1}\nDia chi: {2}", nameCustomer.ToUpper(), idCustomer, addressCus.ToUpper());
        }
        public void outputCusVis()
        {
            Console.WriteLine("Chao mung khach hang {0} ghe tham showroom xe cua chung toi", nameCustomer.ToUpper());
        }
        public void InformationCus() { }
        public void inputCar() { }
        public void outputCar() { }
        public void InformationCar() { }
    }
}
