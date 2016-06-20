using UnityEngine;
using System.Collections;
using System;

class Emp : IComparable
{

    public int IdNumber { get; set; }
    int IComparable.CompareTo(object obj)
    {
        int returnVal;
        Emp tempEmp = (Emp)obj;

        if (this.IdNumber > tempEmp.IdNumber)
        {
            returnVal = 1;
        }
        else if (this.IdNumber < tempEmp.IdNumber)
        {
            returnVal = -1;
        }
        else
        {
            returnVal = 0;
        }
        return returnVal;
    }
}



/*
class Emp: IComparable
{
    public int IdNumber { get; set; }
    public double Salary { get; set; }
    int IComparable.CompareTo(object obj)
    {
        int returnVal;
        Emp temp = (Emp)obj;
        if (this.IdNumber > temp.IdNumber)
        { returnVal = 1; }
        else
        {
            if (this.IdNumber < temp.IdNumber)
            {
                returnVal = -1;
            }
            else
            {
                returnVal = 0;
            }
        }
        return returnVal;
    }
} 
*/
public class ReadoNly : MonoBehaviour {
     
	void Start()
    {

            Emp[] myEmp = new Emp[5];
            int i ;
            for ( i = 0; i < myEmp.Length; i++)
            {
                myEmp[i] = new Emp();
            }

            myEmp[0].IdNumber = 222;
            myEmp[1].IdNumber = 444;
            Emp toSeek = new Emp();
            toSeek.IdNumber = 222;
            for (i = 0;  i< myEmp.Length; i++)
            {
                i = Array.BinarySearch(myEmp, toSeek);
                Debug.Log("Emplyee: " +
               toSeek.IdNumber + " " +
               "found at position: " + i);
            }
           

            /*
            Emp[] empArray = new Emp[5];
            int x;
            for ( x = 0; x < empArray.Length; x++)
            {
                empArray[x] = new Emp(); 
            }
            empArray[0].IdNumber = 333;
            empArray[1].IdNumber = 444;
            empArray[2].IdNumber = 555;
            empArray[3].IdNumber = 111;
            empArray[4].IdNumber = 222;
            Emp seekEmp = new Emp();
            seekEmp.IdNumber = 555;
            Array.Sort(empArray);
            Debug.Log("Array sorted");

            for ( x = 0;  x < empArray.Length;  ++x)
            {
                // index = Array.IndexOf(empArray, seekEmp);
                x = Array.BinarySearch(empArray, seekEmp); 
                Debug.Log("Emplyee: "+
                    seekEmp.IdNumber + " "+
                    "found at position: " + x); 
            }


             */


        }
    

}

    
