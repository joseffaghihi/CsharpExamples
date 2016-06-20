using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Linq;
using AverageSume;
using System.Collections.Generic;

public class SceneChangeButton : MonoBehaviour {

    void OnGUI()   
    {
        if (GUI.Button(new Rect(200, 0, 150, 70),
            "Go To Second Level!"))
        {
            SceneManager.LoadScene("SecondScene");
        }
        
    }
}
