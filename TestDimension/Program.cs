using System;

namespace TestDimension
{
    public class Testoflaptopbag
    {

        public void verifyifthelaptopcanfitinthebag(double areaofbag, double areaoflaptop)
        {


            if(areaofbag < areaoflaptop)
            {
                Console.WriteLine("Laptop wont fit in Bag ");

            }


            else if(areaofbag > areaoflaptop)
            {

                Console.WriteLine("Laptop will fit in Bag");
            }
        }

        public double Calculateareaofbag()
        {


            double length, breadth, area;
            Console.WriteLine("Enter length of Bag : ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter breadth of Bag : ");
            breadth = Convert.ToDouble(Console.ReadLine());

            area = length * breadth;
            Console.WriteLine("\nArea of bag: " + area);
            Console.ReadKey();


            return area;
        }
        public double Calculateareaoflaptop()
        {


            double length, breadth, area1;
            Console.WriteLine("Enter length of Laptop : ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter breadth of Laptop : ");
            breadth = Convert.ToDouble(Console.ReadLine());

            area1 = length * breadth;
            Console.WriteLine("\nArea of Laptop: " + area1);
            Console.ReadKey();


            return area1;
        }



        public static void Main(string[] args)
        {
            Testoflaptopbag t = new Testoflaptopbag();

            double a1 = t.Calculateareaofbag();
            double a2 = t.Calculateareaoflaptop();

            t.verifyifthelaptopcanfitinthebag(a1, a2);


        }
    }
}
