
namespace _10_JaggedArrays
{
    using System;

    class JaggedArraysTest
    {
        static void Main()
        {
            int[][] jaggedArray;
            jaggedArray = new int[2][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];

            int[][,] jaggedOfMulti = new int[2][,];
            jaggedOfMulti[0] = new int[,] { { 5, 15 }, { 125, 206 } };
            jaggedOfMulti[1] = new int[,] { { 3, 4, 5 }, { 7, 8, 9 } };




        }
    }
}
