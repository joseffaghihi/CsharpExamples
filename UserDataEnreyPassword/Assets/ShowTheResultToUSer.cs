using UnityEngine;
using System.Collections.Generic; 
using System.Collections;
using System;
using  PersonCar;


/*
public class Student
{
    private int idNumber;
    private string lastName;
    private double gradePointAverage;
    private List<int> userScoring = new List<int>();
    public const double HIGHEST_GPA = 4.0;
    public const double LOWEST_GPA = 0.0;
    public Student(int id, string lname, double gpa)
   {
       IdNumber = id;
       LastName = lname;
       GradePointAverage = gpa;
   }

    public List<int> UserScoring
    {
        get { return userScoring; }
        set { userScoring = value; }
    }
    public int IdNumber
    {
        get { return idNumber; }
        set { idNumber = value; }
     }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public double GradePointAverage
    {
        get { return gradePointAverage; }
        set
        {
            if(value >= LOWEST_GPA && 
                value <= HIGHEST_GPA)
            {
                gradePointAverage = value;
            }else
            {
                gradePointAverage = LOWEST_GPA;
            }
        }
    }
    

}
 */


public class ShowTheResultToUSer : MonoBehaviour
{
    void Start()
    {
         


        /* List<Boss> cList = new List<Boss>();
        cList.Add()

        Car cCar2 = new Car();
        cCar2.CarName = "Chevy";

        cList.Add(cCar1);
        cList.Add(cCar2);

        Person p1 = new Person();
        p1.FName = "Donnee";
        p1.LName = "Houssi";
        p1.GetSetCar = cList;
        p1.Print(); */
    }

}

 

/*
static int[,] grid = new int[15, 15];
void Start()
{

    grid[0, 1] = 5;
    grid[3, 4] = 6;
    grid[14, 3] = 5;
    int sum = 0;
    foreach(int numbers in GridValues())
    {
        sum += numbers;
    }
    Debug.Log(sum);
}

public static IEnumerable<int> GridValues()
{
    for(int x=0; x<15; x++)
    {
        for(int y =0; y<15; y++)
        {
            yield return grid[x, y];
        }
    }
} */

/*
List<Student> listStudent = new List<Student>();
listStudent.Add(new Student(12, "ddddd", 3.5));
foreach (Student std in listStudent)
    Debug.Log(std.IdNumber + std.LastName +
        std.GradePointAverage);
 */



/*
    private void DisplayStudentInfo(Student myStudent)
    {
        Debug.Log("Student Id: " + myStudent.IdNumber +
            "Student LastName: " + myStudent.LastName +
           "Student GPA: " + myStudent.GradePointAverage);

    }
    */


/*
const double pi = 3.14159;

// constant declaration 
double r =2; 
double areaCircle = pi * r * r;
Debug.Log( r + areaCircle);  */




/*
public class Employee
{ 
private int idNumber;
public int IdNumber
{
    get
    {
        return idNumber;
    }
    set
    {
        idNumber = value;
    }
}


public void SetIdNumber(int number)
{
    idNumber = number;
}


public void DisplayEmpData(string order, Employee emp)
{

    Debug.Log("\n" +emp.IdNumber+ " employee's message:" + order);
    Debug.Log("How can I help you?");

}

}

    */





