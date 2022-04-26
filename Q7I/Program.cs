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
        public Adress Address;
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

        static Adress[] adresses = {new Adress("г.Пермь","ул.Пушкина"), new Adress("г.Пермь", "ул.Толстого"), new Adress("г.Пермь", "ул.Шамиля") };
        public void SetAdress()
        {

            Console.WriteLine("Выб");
            
        }
    }

    class ShopDelivery : Delivery
    {
        public Adress Adress { get; set; }

        public void SetAdress()
        {
 
        }
    }

    class Order<TDelivery, TStruct, TPayment> where TDelivery : Delivery where TPayment : Payment
    {
        public TDelivery Delivery;

        public TPayment Payment;

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
            Console.WriteLine("Имя заказчика:{0},\bФамилия заказчика:{1}", Delivery.Name, Delivery.Lastname);
        }

        public void DisplayNum()
        {
            Console.WriteLine(Number);
        }

        public Products[] Products = {};
        // ... Другие поля
    }

    class Product
    {
        public string Name;
        public string Description;
        public string Price;


    }
    class Products:Product
    {
        public int Count;
    }


    public class Adress
    {
        private string City;
        private string Street;
        private int HouseNum;
        private int ApprtNum;
        public string city { get { return City; } set { City = value; } }
        public string street { get { return Street; } set { Street = value; } }
        public int? houseNum { get { return HouseNum; } set { HouseNum = (int)value; } }
        public int? apprtNum { get { return ApprtNum; } set { ApprtNum = (int)value; } }

        public Adress(string city, string street)
        {
            this.city = city;
            this.street = street;
        }

        public Adress(string city,string street,int? housenum,int? apprtnum)
        {
            this.city = city;
            this.street = street;
            houseNum = housenum;
            apprtNum = apprtnum;
        }
    }
    enum Status
    {
        NotConfirmed, Confirmed, Canlseled
    }
    abstract class Payment
    {
        public Status Status;

       public abstract void PayInfo();
        
    }
    abstract class CardPayment:Payment
    {
        public string Number1;
        private string _number2;
        public string Number2 { get { return "***"; } set { _number2 = value; } }
        public override void PayInfo()
        {
            Console.WriteLine("Введите номер вашей карты");
            Number1 = Console.ReadLine();
            Console.WriteLine("Введите CVC код");
            _number2 = Console.ReadLine();
        }
    }
    class QiWi : Payment
    {
        public string Number;
        public override void PayInfo()
        {
            Console.WriteLine("Введите номер вашего кошелька");
            Number = Console.ReadLine();
        }
    }

    class MasterCard :CardPayment
    {
       
    }
    class Visa : CardPayment
    {
      
    }
}
