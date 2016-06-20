using UnityEngine;
using System.Collections;

public class AdjustScript : MonoBehaviour {

	 void OnGUI()
    {
        if (GUI.Button(new Rect(10, 60, 100, 30), "Health up"))
        { GameController.control.health += 10; } 
        if (GUI.Button(new Rect(10, 100, 100, 30), "Health Down"))
        { GameController.control.health -= 10; }
        if (GUI.Button(new Rect(10, 140, 100, 30), "Experience up"))
        { GameController.control.experience += 10; }
        if (GUI.Button(new Rect(10, 180, 100, 40), "Experience down"))
        { GameController.control.experience -= 10; }
        if (GUI.Button(new Rect(10, 220, 100, 30), "Save"))
        { GameController.control.Save(); } 
        if (GUI.Button(new Rect(370, 10, 100, 30), "Load"))
        { GameController.control.Load(); }
    }
}
