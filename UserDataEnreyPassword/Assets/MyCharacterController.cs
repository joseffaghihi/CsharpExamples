using UnityEngine;
using System.Collections;

public class MyCharacterController : MonoBehaviour {
  

   
    //a pointer to a whole method
    // the following is a signature when click a RaycasObj
    // is sent with it
    public delegate void ClickAction(RaycastHit hitObject);
    // we define OnClick action
    public static event ClickAction OnClick;
    private RaycastHit hitObject;
    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),
                 out hitObject);
            if(OnClick != null){
                OnClick(hitObject);
            }
           
        } 
	} 
}
