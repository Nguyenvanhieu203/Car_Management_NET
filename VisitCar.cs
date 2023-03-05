using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_mua_bán_xe_hơi
{
    internal class VisitCar: ISellPerson, ICustomer, ICar
    {
        // Thông tin nhân viên
        public string nameSell
        {
            get;
            set;
        }
        public string idSell
        {
            get;
            set;
        }
        public int ageSell
        {
            get;
            set;
        }
        public string levelSell
        {
            get;
            set;
        }

        // Thông tin xe
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

        // In thông tin nhân viên
        public void InfomationSell()
        {
            Console.WriteLine("Nhan vien: {0}\nMa nhan vien: {1}\nTuoi: {2}\nChuc vu: {3}", nameSell, idSell, ageSell, levelSell);
        }
        // In thông tin khách hàng
        public void InformationCus()
        {
            Console.WriteLine("Ten khach hang: {0}\nSo CMND: {1}\nDia chi: {2}",nameCustomer , idCustomer , addressCus );
        }

        // In thông tin xe
        public void InformationCar()
        {
            Console.WriteLine("Hang xe: {0}\nNam san xuat: {1}\nGia xe: {2}", modelCar, yearCar , priceCar);
        }
        public void inputCar() { }
        public void outputCar() { }
        public void outputCusVis() { }
        public void outputCus() { }
        public void inputCus() { }
    }
}
