using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//need these for the saving
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using StudentsLevelClass;

public class inputCheck : MonoBehaviour
{

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
            SaveUserInfo(); 
            SceneManager.LoadScene("UsersucessScene");
        }
    }

    private void SaveUserInfo()
    {
        bool RedundantId = false;
        Student data = new Student();
        int tempIdChecking = Int32.Parse(User_ID.text);
        string path = Application.persistentDataPath
          + "/playerInfo.dat";
        //File.Delete(path);


        if (!File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath
             + "/playerInfo.dat");
            Debug.Log(Application.persistentDataPath);

            data.StudentId = Int32.Parse(User_ID.text);
            data.FName = firstName.text;
            data.LName = "Johny";
            //write data to file
            bf.Serialize(file, data);
            file.Close();
        }
        else
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fileOpen = File.Open(Application.persistentDataPath
             + "/playerInfo.dat", FileMode.Open);
            while (fileOpen.Position != fileOpen.Length)
            {
                Student sData = (Student)bf.Deserialize(fileOpen);
                if (sData.StudentId == tempIdChecking)
                {
                    RedundantId = true;
                    //load the data from user
                    Debug.Log("This ID already exist!");
                    break;
                }
            }
            if (RedundantId == false)
            {
                FileStream file = File.Open(Application.persistentDataPath
             + "/playerInfo.dat", FileMode.Append);
                Debug.Log(Application.persistentDataPath);

                data.StudentId = Int32.Parse(User_ID.text); ;
                data.FName = firstName.text;
                data.LName = "Johny";
                //write data to file
                bf.Serialize(file, data);
                file.Close();
            }

        }
    }



    
}

