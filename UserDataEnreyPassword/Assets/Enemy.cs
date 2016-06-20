using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

     
private int health = 10; 
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
       //if this object clicked
       //The Transform of the rigidbody or collider that was hit.
       if (hitObject.transform == transform)
       {
           RemoveHealth();
       } 
    }

    public int GetHealth()
    { 
       return health;
    }

    public void RemoveHealth()
    {
       if(health > 0)
       {
           health--;
           Debug.Log(health);
       }else
       {
           Destroy(gameObject);
       }
    }  
}
