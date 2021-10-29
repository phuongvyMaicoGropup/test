using StoreManage.Products;
using StoreManage.Products.AirConditioner;
using StoreManage.Products.Fan;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace StoreManage
{
    public class Bill
    {
        public Customer customer = new Customer();
        private string id;
        private DateTime dateCreate = DateTime.Now;
        private double totalCost;
        private Product[] products;
        private int amount;
        private string output = "";

        public string Id
        {
            set => id = value;
            get => Id; 
        }

        public void InputBill()
        {
            Write("Mã hóa đơn:");
            Id = ReadLine();
            WriteLine($"Ngày lập hóa đơn: {dateCreate.Day} /{dateCreate.Month} /{dateCreate.Year}  ");
            customer.InputInfo();
            WriteLine("Nhập danh sách các chi tiết hóa đơn:");
            bool check;
            do
            {
                try
                {
                    check = true;
                    Write("\tSố lượng chi tiết trong danh sách cac chi tiết hóa đơn: ");
                    amount = Convert.ToInt32(ReadLine());
                    if (amount <= 0) check = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine("\t\t" + error.Message + " Sai định dạng ");
                    check = false;
                }
            } while (check == false);
            
            products = new Product[amount]; 
            for (int i = 0; i< amount; i++)
            {
                WriteLine($"\tNhập chi tiết hóa đơn thứ {i + 1}");
                int answer = -1;
                do
                {
                    try
                    {
                        check = true;
                        Write("\t\tChọn loại thiết bị điện (1-máy quạt, 2- máy lạnh):");
                        answer = Convert.ToInt32(ReadLine());
                        if (answer <= 0) check = false;
                    }
                    catch (Exception error)
                    {
                        WriteLine("\t" + error.Message + "Sai định dạng ");
                        check = false;
                    }
                } while (answer != 1 && answer != 2 || check == false) ;
                if (answer == 1)
                {

                    int TypeOfFan = -1 ;
                    do
                    {
                        try
                        {
                            check = true;
                            Write("\t\t\tChọn loại máy quạt (1-máy quạt đứng,2- máy quạt hơi nước,3 – máy quạt sạc điện): ");
                            TypeOfFan = Convert.ToInt32(ReadLine());
                        }
                        catch (Exception error)
                        {
                            WriteLine("\t" + error.Message + "Sai định dạng ");
                            check = false;
                        }
                    } while (TypeOfFan != 1 && TypeOfFan!=2 && TypeOfFan != 3 || check == false);
                    check = true;
                    do
                    {
                        switch (TypeOfFan)
                        {
                            case 1:
                                check = true;
                                products[i] = new DefaultFan();
                                break;
                            case 2:
                                check = true;
                                products[i] = new SteamFan();
                                break;
                            case 3:
                                products[i] = new ElectricFan(); 
                                check = true;
                                break;
                            default:
                                check = false;
                                break;
                        }
                    } while (check == false);
                }
                else
                {
                    int TypeOfAirConditioner = -1;
                    do
                    {
                        try
                        {
                            check = true;
                            Write("\t\t\tChọn loại máy lạnh (1-máy lạnh một chiều,2- máy lạnh hai chiều ): ");
                            TypeOfAirConditioner = Convert.ToInt32(ReadLine());
                        }
                        catch (Exception error)
                        {
                            WriteLine("\t" + error.Message + "Sai định dạng ");
                            check = false;
                        }
                    } while (TypeOfAirConditioner != 1 && TypeOfAirConditioner != 2 || check == false);
                    
                    do
                    {
                        switch (TypeOfAirConditioner)
                        {
                            case 1:
                                check = true;
                                products[i] = new OneWayAirConditioner();
                                break;
                            case 2:
                                check = true;
                                products[i] = new TwoWayAirConditioner();
                                break;
                            default:
                                check = false;
                                break;
                        }
                    } while (check == false);
                }
                products[i].InputProduct();
                output+= products[i].ReturnInfoProduct();
                totalCost += products[i].Price()* products[i].Amount; 
            }

            
        }
        public void PrintBill(int index)
        {
            var filename = $"danh_sach_hoa_don_{index}.txt";
            string contentFile = "";
            contentFile += $"\tHóa đơn : {id}  {dateCreate.Day} /{dateCreate.Month} /{dateCreate.Year}  {totalCost} \n";
            contentFile += customer.PrintInfo();
            contentFile += "\tDanh sách các chi tiết hóa đơn:\n";
            contentFile += output; 
            var directory_mydoc = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var fullpath = Path.Combine(directory_mydoc, filename);
            File.WriteAllText(fullpath, contentFile);

            WriteLine($"File lưu tại {directory_mydoc}{Path.DirectorySeparatorChar}{filename}");
        }
    }
}
