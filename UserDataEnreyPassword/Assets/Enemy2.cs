using UnityEngine;
using System.Collections;

public class Enemy2 : MonoBehaviour {

    private int health = 20;

     void OnEnable()
    {
        MyCharacterController.OnClick += MyCharacterController_OnClick;
    }

    void OnDisable()
    {
        MyCharacterController.OnClick -= MyCharacterController_OnClick;
    }

    private void MyCharacterController_OnClick(RaycastHit hitObject)
    {
        if(hitObject.transform == transform)
        {
            RemoveHealth();
        }

    }

    void RemoveHealth()
    {
        if(health > 0)
        {
            health -= 5;
            Debug.Log("Helath goes down by -5: " + health );
        }else
        { Destroy(gameObject); }
    }

}
