using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillDivision
{
    internal class Result
    {
        public static void bonAppetit(List<int> billItems, int chargedAnna, int itemNotShared)
        {
            int[] arrItems = billItems.ToArray();
            int amountBill = 0;

            for(int i = 0; i < arrItems.Length; i++)
                if (arrItems[i] != arrItems[itemNotShared])
                    amountBill+=arrItems[i];

            if(amountBill / 2 == chargedAnna)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(Convert.ToString(chargedAnna - (amountBill / 2)));


        }
    }
}
