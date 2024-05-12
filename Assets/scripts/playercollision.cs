
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public movement playermovement;
  

 
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle") 
        {
            playermovement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
           
        }


        
        

    }

  
}
