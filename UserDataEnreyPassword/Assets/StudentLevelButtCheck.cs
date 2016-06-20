using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using StudentsLevelClass;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StudentLevelButtCheck : MonoBehaviour {
    //Correspond to the fields in the Scene
    public InputField firstName, User_ID;
    //  public GameObject instructions; 
    public void checkInputs()
    {

        if (firstName.text == "" || User_ID.text == "")
        {

            Debug.Log("Check you fields! ");
        }

        else
        {
            SaveUserLevelsInfo();
            SceneManager.LoadScene("UsersucessScene");
        }
    }
    private void SaveUserLevelsInfo()
    {
        
        Level data = new Level();
        int tempIdChecking = Int32.Parse(User_ID.text);
        string path = Application.persistentDataPath
          + "/playerLevelsInfo.dat";
        //File.Delete(path);


        if (!File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath
             + "/playerLevelsInfo.dat");
            Debug.Log(Application.persistentDataPath);

            data.StudentId = Int32.Parse(User_ID.text);
            data.QuestionId = Int32.Parse(firstName.text);
            data.LevelScore = 50;
            //write data to file
            bf.Serialize(file, data);
            file.Close();
        }
        else
        {
            BinaryFormatter bfL = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath
             + "/playerLevelsInfo.dat", FileMode.Append);
                Debug.Log(Application.persistentDataPath);

                data.StudentId = Int32.Parse(User_ID.text); ;
                data.QuestionId = Int32.Parse(firstName.text);
            data.LevelScore = 50;
                //write data to file
                bfL.Serialize(file, data);
                file.Close();
            }

        }
 }

