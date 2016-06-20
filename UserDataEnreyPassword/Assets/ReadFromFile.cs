using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
 
class CurentDate
{
    private int _month, _day, _year;
    private string _monthName;

    public CurentDate()
    {
        _month = 1; _day = 1; _year = 2016;
        _monthName = "January";
    }
    public CurentDate(int m, int d, int y)
    {
        this.Month = m; 
        this.Day = d;
        this.Year = y;
    }
    public int Month
    {
        get { return _month; }
        set
        {
            if (value <1 || value > 12)
            {
                Debug.Log("Month must be between 1-12");
                _month = 1;
                MonthName(_month);
            }
            else
            {
                _month = value;
                MonthName(_month);
            }
        }  
    }
    public void MonthName (int m)
    {
         
            switch (m)
            {
                case 1:
                    _monthName = "January";
                    break;
                case 2:
                    _monthName = "February";
                    break;
            case 3:
                _monthName = "March";
                break;
                // here  is the rest...
        }
     }
        
    public int Day
    {
        get { return _day; }
        set
        {
            int tempDay;
            if(value < 1 || value > 31)
            {
                Debug.Log("The value must be between 1-31");
            }
            else
            {
                switch (value)
                {
                    // Apr., June, Sept.,Nov
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        tempDay = 30; break;
                    case 2: tempDay = 29; break;
                    default: tempDay = 31; break;
              
                }
                if (value >= 1 && value <= tempDay)
                    _day = value;
                else
                {
                    Debug.Log("The day is not valid");
                    _day = 1;
                }
            }
        }
    }

    public int Year
    {
        get { return _year; }
        set
        {
            if (value >=1900 && value <= 2020)
            {
                _year = value;
            }else
            {
                Debug.Log("invlaid year");
                _year = 2016;
            }
                  
        }
      
    }

    public void showDate()
    {
        Debug.Log(_month + "/ " +
            _day + "/ " + _year);
    }
    public void showDate2()
    {
        Debug.Log(_monthName + " " +
            _day + " " + _year);
    }
    public void showDate3()
    {
        Debug.Log(_day + " " +
            _monthName + " " + _year);
    }
} 

public class ReadFromFile : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        CurentDate cr = new CurentDate();
        cr.Month =3;
        cr.Day = 20;
        cr.Year = 2015;
        cr.showDate();
        cr.showDate2();
        cr.showDate3();
        cr.showDate();
    }

}

 
 
