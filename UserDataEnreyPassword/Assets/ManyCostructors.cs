using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using StudentsLevelClass;
/*
class Employee
{  
   int _idNumber;
   public int IdNumber
   {
       get { return _idNumber; }
       set {_idNumber = value; }
   }
   public double Salary { get; set; }
   public Employee(): this(999,0)
   {  }
   public Employee(int empId):
       this(empId,0)
   {     }
   public Employee(int empId, double sal)
   {
       IdNumber = empId;
       Salary = sal;
   }
   public Employee(char code):
       this(111, 100000)
   {     }
}
*/
public class ManyCostructors : MonoBehaviour
{
    void Start()
    {  
        List<Level> levelList = new List<Level>();
        Level level1 = new Level();
        level1.QuestionId = 1;
        level1.LevelScore = 100;
        level1.Success = 0;
        Level level1s = new Level();
        level1s.QuestionId = 1;
        level1s.LevelScore = 150;
        level1s.Success = 1;

        levelList.Add(level1);
        levelList.Add(level1s);

        Student student1 = new Student();
        student1.StudentId = 5101;
        student1.FName = "Donnee";
        student1.LName = "Houssi";
        student1.GetSetLevels = levelList;
         


        //create mydata file
        CreateBasicDataFile(student1.StudentId, student1.FName, student1.LName);
        //reading from mydata file
        ReadFromBasicDataFile();
        foreach(Level l in levelList)
        {
            CreatePerformanceDataFile(student1.StudentId, l.QuestionId,
            l.LevelScore, l.Success, l.HintId);
        } 
        ReadFromPerformanceFile();

    }

    private void ReadFromBasicDataFile()
    {
        BinaryReader br;
        try
        {
            br = new BinaryReader(new FileStream("Assets/mydata", FileMode.Open));
        }
        catch (IOException e)
        {
            Debug.Log(e.Message + "\n Cannot open file.");
            return;
        }
        try
        {
            Debug.Log("Person ID: " + br.ReadInt32());
            Debug.Log("Person First Name: " + br.ReadString());
            Debug.Log("Person Last Name: " + br.ReadString());
        }
        catch (IOException e)
        {
            Debug.Log(e.Message + "\n Cannot read from file.");
            return;
        }
        br.Close();
    }

    private void CreateBasicDataFile(int id, string fn, string lname)
    {
        BinaryWriter bw;
        try
        {
            bw = new BinaryWriter(new FileStream("Assets/mydata", FileMode.Create));
            Debug.Log("File is Created");
        }
        catch (IOException e)
        {
            Debug.Log(e.Message + "\n Cannot create file.");
            return;
        }

        //writing into the file
        try
        {
            // bw.Write(i);
            bw.Write(id);
            bw.Write(fn);
            bw.Write(lname);

        }

        catch (IOException e)
        {
            Debug.Log(e.Message + "\n Cannot write to file.");
            return;
        }
        bw.Close();
    }

    
    private void CreatePerformanceDataFile(int sid, int lid,int ls,
            int lsf, int lh)
    {
        BinaryWriter bw;
        try
        {

            bw = new BinaryWriter(new FileStream("Assets/myPerformance", FileMode.Append));
            Debug.Log("myPerformance is Created");
        }
        catch (IOException e)
        {
            Debug.Log(e.Message + "\n Cannot create file.");
            return;
        }
         
        //writing into the file
        try
        {
            bw.Write(sid);
            bw.Write(lid);
            bw.Write(ls);
            bw.Write(lsf);
            bw.Write(lh);
            Debug.Log("writting to myPerformance is finished");
        }

        catch (IOException e)
        {
            Debug.Log(e.Message + "\n Cannot write to file.");
            return;
        }
        Debug.Log("Car data is written");
        bw.Close();
    }

    private void ReadFromPerformanceFile()
    {

        BinaryReader br;
        try
        {
            br = new BinaryReader(new FileStream("Assets/myPerformance", FileMode.Open));
        }
        catch (IOException e)
        {
            Debug.Log(e.Message + "\n Cannot open file.");
            return;
        }
        try
        {
             
            // first record of the file
             br.BaseStream.Position = 0;
            //End of file checking
             while (br.BaseStream.Position != br.BaseStream.Length)
            { 
                Debug.Log("StudentId ID: " + br.ReadInt32());
                Debug.Log("CurrentLevel: " + br.ReadInt32());
                Debug.Log("LevelScore: " + br.ReadInt32());
                Debug.Log("Success: " + br.ReadInt32());
                Debug.Log("Success: " + br.ReadInt32());
               // Debug.Log("HintId: " + br.ReadString());
            }
           
        }
        catch (IOException e)
        {
            Debug.Log(e.Message + "\n Cannot read from file.");
            return;
        }
        br.Close();
    }
}


    /*
// Use this for initialization
void Start () {
    Employee aWorker = new Employee();
    Employee anotherWorker = new Employee(234);
    Employee theBoss = new Employee('A');
    Debug.Log("First Emp: " + aWorker.IdNumber +
        "Salary: " + aWorker.Salary.ToString());
    Debug.Log("Second Emp: " + anotherWorker.IdNumber +
        "Second Salary: "+anotherWorker.Salary.ToString());
    Debug.Log("Third Emp: " + theBoss.IdNumber +
       "Third Salary"+ theBoss.Salary.ToString());
}
 
    */

