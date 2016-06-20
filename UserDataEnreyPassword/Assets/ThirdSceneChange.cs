using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ThirdSceneChange : MonoBehaviour
{

    void OnGUI()
    {
        if (GUI.Button(new Rect(200, 0, 150, 70),
            "Go To First Level!"))
        {
            SceneManager.LoadScene("FirstScene");
        }
    }
}
