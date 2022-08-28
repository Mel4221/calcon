using System;

namespace Console_Calculator
{
    class Program
    {

                    ///<summary>
                    /// If the operation is not suppored this will say it 
                    ///</summary>
          static void NotSuported()
          {
                    
          Console.WriteLine("Invalid Operation or not suppored");
          Console.WriteLine("Valid Operation Format  a + b");
          Console.WriteLine("Operations allowed + , - , * , / , ^");

          }

        static void Main(string[] args)
        {
          try{
           
                    
                  Console.ForegroundColor = ConsoleColor.Green;

            // values taken from the console 
            double v1 = 0; 
            double v2 = 0; 

            string f = null; 
       


          if(args.Length == 0)
          {

            Console.WriteLine("Welcome To Console Calculator");
            Console.WriteLine("Created By MBV \n"); 
            Console.WriteLine("Please Introduce value1...:");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("PLease Introduce the Type of operation...:");
            Console.WriteLine("Operation allwoed:  +  -  /   ^ ");
            f = Console.ReadLine();
            Console.WriteLine("Please Introduce  value2...:");
            v2 = Convert.ToDouble(Console.ReadLine());
                    double total = Calculate(v1,f,v2);
       
          }if(args.Length == 3){
                  //  Console.WriteLine("Recived Value");
                    v1 = Convert.ToDouble(args[0]); 
                    f = args[1];
                    v2 = Convert.ToDouble(args[2]); 
                   double total =  Calculate(v1,f,v2);
 
          }else{
                    NotSuported();
         
          }
           
          }catch
          {

                     NotSuported();
         
          }

        	Console.ResetColor(); 
        }



          static double Calculate(double v1 , string f , double v2)
          {
                  //  Console.WriteLine("Calculation:");
                    double x = 0 ; 
            if (f == "+") {
                x = v1+v2;
                Console.WriteLine(" {0} {1} {2} = {3}", v1,f,v2,x);
            }
            if(f == "-"){
                x = v1 - v2;
                Console.WriteLine(" {0} {1} {2} = {3}", v1, f, v2, x);

            }
            if (f == "x" || f == "X")
            {
                x = v1 * v2;
                Console.WriteLine(" {0} {1} {2} = {3}", v1, f, v2, x);

            }
            if (f == "/")
            {
                x = v1 / v2;
                Console.WriteLine(" {0} {1} {2} = {3}", v1, f, v2, x);

            }
            if (f == "%")
            {
                x = v1 % v2;
                Console.WriteLine(" {0} {1} {2} = {3}", v1, f, v2, x);

            }
            if (f == "^")
            {
                x = (v1 * v1) * v2;
               
               Console.WriteLine(" {0} {1} {2} = {3}", v1, f, v2, x);
             
            }


                              return x;      
          }
    }
}
