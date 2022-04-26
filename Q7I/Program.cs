using System;

namespace Q7I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    abstract class Delivery
    {
        public string Address;
        public string Name;
        public string Lastname;
    }

    class HomeDelivery : Delivery
    {
        public  Adress Adress { get; set; }

        public void SetAdress() 
        {
            Console.WriteLine("Введите город доставки:");
            Adress.city=Console.ReadLine();
            Console.WriteLine("Введите улицу доставки:");
            Adress.street = Console.ReadLine();
            Console.WriteLine("Введите номер дома доставки:");
            Adress.houseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер квартиры доставки:");
            Adress.apprtNum = Convert.ToInt32(Console.ReadLine());
        }
    }

    class PickPointDelivery : Delivery
    {
        public Adress Adress { get; set; }

        public void SetAdress()
        {
            Console.WriteLine("Введите город доставки:");
            Adress.city = Console.ReadLine();
            Console.WriteLine("Введите улицу доставки:");
            Adress.street = Console.ReadLine();
            Console.WriteLine("Введите номер дома доставки:");
            Adress.houseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер квартиры доставки:");
            Adress.apprtNum = Convert.ToInt32(Console.ReadLine());
        }
    }

    class ShopDelivery : Delivery
    {
        public Adress Adress { get; set; }

        public void SetAdress()
        {
            Console.WriteLine("Введите город доставки:");
            Adress.city = Console.ReadLine();
            Console.WriteLine("Введите улицу доставки:");
            Adress.street = Console.ReadLine();
            Console.WriteLine("Введите номер дома доставки:");
            Adress.houseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер квартиры доставки:");
            Adress.apprtNum = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Order<TDelivery,TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
        public void DisplayDescription()
        {
            Console.WriteLine(Description);
        }
        public void DisplayUserInfo()
        {
            Console.WriteLine("Имя заказчика:{0},\bФамилия заказчика:{1}",Delivery.Name,Delivery.Lastname);
        }

        // ... Другие поля
    }
    public class Adress
    {
        private string City;
        private string Street;
        private int HouseNum;
        private int ApprtNum;
        public string city { get { return City; } set { City = value; } }
        public string street { get { return Street; } set { Street = value; } }
        public int houseNum { get { return HouseNum; } set { HouseNum = value; } }
        public int apprtNum { get { return ApprtNum; } set { ApprtNum = value; } }

        public Adress()
        {
           
        }

        public Adress(string city,string street,int housenum,int apprtnum)
        {
            this.city = city;
            this.street = street;
            houseNum = housenum;
            apprtNum = apprtnum;
        }
    }
}
