using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obstacle : MonoBehaviour
{
    public GameManager gameManager;
    private void OnCollisionEnter(Collision collision){
        if (collision.collider.tag == "obstacle")
            gameManager.endGame();
        if(collision.collider.tag == "coin"){
            Destroy(this.gameObject);
        }    
    }
  
}
