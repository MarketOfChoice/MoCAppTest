using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoCTestApp.Models;

namespace MoCTestApp.Helpers
{
    public class Numbers
    {
        public static List<int> getEvenNumbers(int startNum, int endNum)
        {
            List<int> numberList = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if(i % 2 == 0)
                {
                    numberList.Add(i);
                }
            }

            return numberList;
        }
    }
}
