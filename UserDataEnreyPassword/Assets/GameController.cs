using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;
using StudentsLevelClass;


public class GameController : MonoBehaviour
{

    public static GameController control;

    public int health;
    public float experience;

    //singeltone
    void Awake()
    {
        //if there is NotificationServices game control 
        // make this as game control 
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
            //if control already exist
            // and this is not it then destroy
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "health: " + health);
        GUI.Label(new Rect(10, 40, 150, 30), "experience: " + experience);
    }

    public void Save()
    {
        string path = Application.persistentDataPath
          + "/playerInfo.dat";
        if (!File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath
             + "/playerInfo.dat");
            Debug.Log(Application.persistentDataPath);
            Student data = new Student();
            data.StudentId = 501;
            data.FName = "John";
            data.LName = "Johny";
            //write data to file
            bf.Serialize(file, data);
            file.Close();
        }
        else
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath
             + "/playerInfo.dat",FileMode.Append);
            Debug.Log(Application.persistentDataPath);
            Student data = new Student();
            data.StudentId = 501;
            data.FName = "John";
            data.LName = "Johny";
            //write data to file
            bf.Serialize(file, data);
            file.Close();
        }


        string pathL = Application.persistentDataPath
                + "/playerLevelInfo.dat";
        if (!File.Exists(pathL))
        {
            BinaryFormatter bfL = new BinaryFormatter();
            FileStream fileL = File.Create(Application.persistentDataPath
                + "/playerLevelInfo.dat");
            Debug.Log(Application.persistentDataPath);
            Level sLevels = new Level();
            sLevels.StudentId = 501;
            sLevels.QuestionId = 1;
            sLevels.LevelScore = health;
            sLevels.Success = 1;
            bfL.Serialize(fileL, sLevels);
            fileL.Close();
        }else
        {
            BinaryFormatter bfL = new BinaryFormatter();
            FileStream fileL = File.Open(Application.persistentDataPath
                + "/playerLevelInfo.dat", FileMode.Append);
             
            Debug.Log(Application.persistentDataPath);
            Level sLevels = new Level();
            sLevels.StudentId = 501;
            sLevels.QuestionId = 1;
            sLevels.LevelScore = health;
            sLevels.Success = 1;
            bfL.Serialize(fileL, sLevels);
            fileL.Close();
        }
      

    }
    public void Load()
    {
         
        if (File.Exists(Application.persistentDataPath+
            "/playerLevelInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(
                Application.persistentDataPath +
                "/playerLevelInfo.dat", FileMode.Open); 
            while (file.Position != file.Length)
            {
                Level lData = (Level)bf.Deserialize(file);
                if (lData.StudentId == 501)
                {
                    health = lData.LevelScore;
                    Debug.Log(health);
                }  
            }  
        }
    }
}

 

