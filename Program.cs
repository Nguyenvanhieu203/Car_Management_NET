using System;
using Ứng_dụng_mua_bán_xe_hơi;

namespace QLBX
{
    class Program
    {
        static void Main(string[] args)
        {
            int chose,chose1,chose2, CusChoseCar;
            string dateBuy;
            float price;
            Console.Write("Nhap so luong xe o to co trong showroom: ");
            int listcar = int.Parse(Console.ReadLine());
            ListCar[] lcar = new ListCar[listcar];
            ListCus[] lcus = new ListCus[1];
            do
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("1. Nhap thong tin");
                Console.WriteLine("2. Tham quan phong trung bay");
                Console.WriteLine("3. Khach hang chon lua mot xe hoi");
                Console.WriteLine("4. Khach hang dat hoa don");
                Console.WriteLine("5. Khach hang tra tien");
                Console.WriteLine("6. Giao xe cho khach");
                Console.WriteLine("----------------------------------------");
                Console.Write("Moi chon: ");
                chose = int.Parse(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("1. Nhap thông tin nhân viên");
                            Console.WriteLine("2. Nhap thông tin khách hàng");
                            Console.WriteLine("3. Nhap thông tin xe ô tô");
                            Console.WriteLine("----------------------------------------");
                            Console.Write("Moi chon: ");
                            chose1 = int.Parse(Console.ReadLine());
                            switch (chose1)
                            {
                                case 1:
                                    VisitCar vc = new VisitCar();
                                    Console.WriteLine("Nhap thong tin nhan vien: ");
                                    Console.Write("Nhap ten nhan vien: ");
                                    vc.nameSell = Console.ReadLine();
                                    Console.Write("Nhap ma nhan vien: ");
                                    vc.idSell = Console.ReadLine();
                                    Console.Write("Nhap tuoi nhan vien: ");
                                    vc.ageSell = int.Parse(Console.ReadLine());
                                    Console.Write("Nhap chuc vu: ");
                                    vc.levelSell = Console.ReadLine();
                                    break;
                                case 2:
                                    for(int i=0;i<lcus.Length;i++)
                                    {
                                        lcus[i] = new ListCus();
                                        lcus[i].inputCus();
                                    }
                                    break;
                                case 3:
                                    for (int i=0;i<listcar;i++)
                                    {
                                        Console.WriteLine("Nhap thong tin xe thu {0}", i + 1);
                                        lcar[i] = new ListCar();
                                        lcar[i].inputCar();
                                    }
                                    break;
                            }
                        } while (chose1 < 3);
                        break;
                    case 2:
                        for(int i=0;i<lcus.Length;i++)
                        {
                            lcus[i].outputCusVis();
                        }
                        Console.WriteLine("Cac mau xe chung toi co la: ");
                        for(int i=0;i<listcar;i++)
                        {
                            Console.WriteLine("Thong tin xe " + (i + 1) + " :");
                            lcar[i].outputCar();
                        }
                        break;
                    case 3:
                        Console.Write("Moi chon chiec xe ban muon mua (theo thu tu chiec xe): ");
                        CusChoseCar = int.Parse(Console.ReadLine());
                        for(int i=0;i<lcus.Length;i++)
                        {
                            Console.Write("Khach hang {0} da lua chon xe ", lcus[i].nameCustomer.ToUpper());
                        }
                        for(int i=1;i<=listcar;i++)
                        {
                            if(CusChoseCar == i)
                            {
                                Console.Write(lcar[i].modelCar.ToUpper());
                            }
                        }
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Console.Write("Moi chon chiec xe ban muon mua (theo thu tu chiec xe): ");
                        CusChoseCar = int.Parse(Console.ReadLine());
                        Console.Write("Nhap ngay mua(dd/mm/yyyy): ");
                        dateBuy = Console.ReadLine();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Thong tin hoa don la: ");
                        for (int i = 0; i < lcus.Length; i++)
                        {
                            lcus[i].outputCus();
                        }
                        for (int i = 1; i <= listcar; i++)
                        {
                            if (CusChoseCar == i)
                            {
                                lcar[i].outputCar();
                            }
                        }
                        Console.WriteLine("Ngay mua: {0}", dateBuy);
                        break;
                    case 5:
                        Console.Write("Moi chon chiec xe ban muon mua (theo thu tu chiec xe): ");
                        CusChoseCar = int.Parse(Console.ReadLine());
                        Console.Write("Nhap so tien khach thanh toan: ");
                        price = float.Parse(Console.ReadLine());
                        for(int i=1;i<=listcar;i++)
                        {
                            if (CusChoseCar == i && price == lcar[i].priceCar)
                            {
                                Console.WriteLine("Khach hang da thanh toan thanh cong");
                            }
                            else if (CusChoseCar == i && price > lcar[i].priceCar)
                            {
                                Console.WriteLine("Khach thua: {0}", (price - lcar[i].priceCar));
                            }
                            else if(CusChoseCar == i && price < lcar[i].priceCar)
                            {
                                Console.WriteLine("Khach thieu: {0}", (lcar[i].priceCar - price));
                            }
                        }
                        break;
                    case 6:
                        Console.Write("Moi chon chiec xe ban muon mua (theo thu tu chiec xe): ");
                        CusChoseCar = int.Parse(Console.ReadLine());
                        Console.Write("Nhap so tien khach thanh toan: ");
                        price = float.Parse(Console.ReadLine());
                        for (int i = 1; i <= listcar; i++)
                        {
                            if (CusChoseCar == i && price == lcar[i].priceCar)
                            {
                                for(int j=0;j<lcus.Length;j++)
                                {
                                    lcus[j].outputCus();
                                }
                                Console.WriteLine("Da nhan chiec xe {0}", lcar[i].modelCar.ToUpper());
                            }
                        }
                        break;
                                
                }
            } while (chose <6);
        }
    }
 }