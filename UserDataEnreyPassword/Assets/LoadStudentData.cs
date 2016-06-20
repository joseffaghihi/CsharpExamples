using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;
using StudentsLevelClass;

public class LoadStudentData : MonoBehaviour {
    public int health;
    public float experience;
     
    public InputField User_ID;

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "health: " + health);
        GUI.Label(new Rect(10, 40, 150, 30), "experience: " + experience);
    }

    public void Load()
    {
        string path = Application.persistentDataPath +
            "/playerLevelInfo.dat";
        //File.Delete(path);
        if (File.Exists(Application.persistentDataPath
          + "/playerLevelsInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(
                Application.persistentDataPath
          + "/playerLevelsInfo.dat", FileMode.Open);
            while (file.Position != file.Length)
            {
                Level lData = (Level)bf.Deserialize(file);
                if (lData.StudentId == Int32.Parse(User_ID.text))
                {
                    health = lData.LevelScore;
                    Debug.Log(health);
                }
            }
        }
    }
     
	 
}
