using UnityEngine;
using System.Collections;

namespace AverageSume
{
    public class AveSum
    {
        private int largest, sum, count;
        private bool inNewLargest(int number)
        {
            if (number > largest)
                return true;

            else
                return false;
        }

        public AveSum()
        {
            largest = sum = count = 0;
        }
        public bool addNumber(int n)
        {
            bool goodNum = true;
            if (n >= 0)
            {
                sum += sum;
                count++;
                if (inNewLargest(n))
                    largest = n;
            }
            else
            {
                goodNum = false;
            }

            return goodNum; 
        }
        public double getaverage()
        {
            if (count > 0)
            {
                return sum /= count;
            }
            else return 0;
        }
        
    }
}

