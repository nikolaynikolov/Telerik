////Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Text;

class program
{

    public static void Main()
    {

        int num = int.Parse(Console.ReadLine());
        int delimna9 = num / 9;
        int delimsprocentna9 = num % 9;
        string numLenght = num.ToString();

        while (true)
        {
            
        }


        //for (int i = 0; i < numLenght.Length; i++)
        //{
        //    int resModul = num % 9;



        //    Console.WriteLine(delimsprocentna9);
        //}





        //    while (quotient != 0)
        //    {

        //   octalNumber[i++] = quotient % 9;

        //quotient = quotient % 9;


        //switch (quotient)
        //{
        //    case 0: list.Append("LON+");
        //        break;
        //    case 1: list.Append("VK-");
        //        break;
        //    case 2: list.Append("*ACAD");
        //        break;
        //    case 3: list.Append("^MIM");
        //        break;
        //    case 4: list.Append("ERIK|");
        //        break;
        //    case 5: list.Append("SEY&");
        //        break;
        //    case 6: list.Append("EMY>>");
        //        break;
        //    case 7: list.Append("/TEL");
        //        break;
        //    case 8: list.Append("<<DON");
        //        break;
        //}
        //   }
        Console.Write("Equivalent Octal Number is ");
        //Console.WriteLine(list);


    }

}


//using System;
//using System.Text;

//class DecToHex
//{
//    static void Main()
//    {
//        Console.WriteLine("Please enter decimal number:");
//        int number = int.Parse(Console.ReadLine());
//        StringBuilder list = new StringBuilder();
//        while (number != 0)
//        {
//            if (number % 9 > 9)
//            {
//                switch (number % 9)
//                {
//                    case 0: list.Append("LON+");
//                        break;
//                    case 1: list.Append("VK-");
//                        break;
//                    case 2: list.Append("*ACAD");
//                        break;
//                    case 3: list.Append("^MIM");
//                        break;
//                    case 4: list.Append("ERIK|");
//                        break;
//                    case 5: list.Append("SEY&");
//                        break;
//                    case 6: list.Append("EMY>>");
//                        break;
//                    case 7: list.Append("/TEL");
//                        break;
//                    case 8: list.Append("<<DON");
//                        break;
//                }
//            }
//            else
//            {
//                list.Append((number % 9).ToString());
//            }
//            number /= 9;
//        }
//        for (int i = 0; i < list.Length; i++)
//        {
//            Console.Write(list[i]);
//        }



//        Console.WriteLine();
//    }
//}

