using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedScaler : MonoBehaviour
{
    public GameObject gameManager;
    public bool state;
    void Start(){
        gameManager = GameObject.FindWithTag("Game");
    }
    private void OnTriggerEnter(Collider other){
            Destroy(gameObject);
        if(state)
            gameManager.GetComponent<GameManager>().Speed();
        
        if(state==false){
            gameManager.GetComponent<GameManager>().SpeedSlow();
        }
    }   
}
