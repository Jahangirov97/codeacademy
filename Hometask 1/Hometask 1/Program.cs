namespace Hometask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double mebleg = 10000;
            
            double dollarrate = 1.70d;
            double eurorate = 1.80d;
            double rublrate = 0.25d;


            double dollar = mebleg / dollarrate;
            double euro = mebleg / eurorate;
            double rubl = mebleg / rublrate;

            Console.WriteLine(" Məbləğ (AZN):");

            Console.WriteLine(mebleg);



            Console.WriteLine("ABŞ dolları (USD):");

            Console.WriteLine(dollar);
            //Console.WriteLine(dollar);

            Console.WriteLine("Avro (EUR):");
            Console.WriteLine(euro);

            Console.WriteLine("Rusiya rublu (RUB):");
            Console.Write(rubl);







        }
    }
}
        
    
