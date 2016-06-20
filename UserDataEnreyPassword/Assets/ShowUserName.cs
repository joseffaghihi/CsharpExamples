using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ShowUserName : MonoBehaviour {

    Text text;
    UserClass userName = new UserClass();

    void Awake()
    {
        text = GetComponent<Text>();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Good Job " + UserClass.player.firstName +
            "! Lets Begin the Game" ;
    }
}
