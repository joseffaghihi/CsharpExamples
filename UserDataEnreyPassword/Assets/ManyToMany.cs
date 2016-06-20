using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cricketer
{
    private string _name;
    private List<Cricketer> CList = new List<Cricketer>();
    private List<Matches> MLst = new List<Matches>();
    public string Name { get; set; }

    public List<Matches> GetSetMatch
    {
        get { return MLst; }
        set { MLst = value; }
    }
    public List<Cricketer> GetSetCricketer
    {
        get { return CList; }
        set { CList = value; }
    }
    public void Print()
    {
        Debug.Log("-----Cricketer Name---- ");
        foreach (Cricketer c in CList)
        {
            Debug.Log("c name: " + c.Name);
        }
        Debug.Log("-----Matches Played----");
        foreach (Matches m in MLst)
        {
            Debug.Log(m.MatchVs);
        }
    } 
}

public class Matches
{
    private List<Cricketer> CLst = new List<Cricketer>();
    public string MatchVs { get; set; }
    public void Print()
    {
        Debug.Log("Match Verses");
        foreach (Cricketer c in CLst)
        {
            Debug.Log("Cricketer Name:- " + c.Name);
        }
    }
}

public class ManyToMany : MonoBehaviour {

	// Use this for initialization
	void Start () {
        List<Cricketer> CList = new List<Cricketer>();
        List<Matches> MList = new List<Matches>();

        Cricketer c = new Cricketer();
        c.Name = "Sourav Ganguly";
        CList.Add(c);
        c = new Cricketer(); 
        c.Name = "Sachin Tendulkar"; 
        CList.Add(c);

        //Add Matches
        Matches m = new Matches();
        m.MatchVs = "India-Sri Lanka";
        MList.Add(m);
        //Add another match

        m = new Matches(); 
        m.MatchVs = "India - Bangladesh"; 
        MList.Add(m);

        c.GetSetCricketer = CList;
        c.GetSetMatch = MList;
        c.Print();


    }

}
