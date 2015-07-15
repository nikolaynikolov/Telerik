//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OrderWords
{

    public static List<string> sort(List<string> listToSort)
    {
        int listSize = listToSort.Count;
        for (int i = 0; i < listSize; i++)
        {
            for (int j = 0; j < listSize; j++)
            {
                if (string.Compare(listToSort[i], listToSort[j]) < 0)
                {
                    string tempValue = listToSort[j];
                    listToSort[j] = listToSort[i];
                    listToSort[i] = tempValue;
                }
            }
        }

        return listToSort;
    }

    static void Main()
    {

    }


}

