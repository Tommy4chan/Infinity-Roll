using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameObject gameManager;
    void Start(){
        gameManager = GameObject.FindWithTag("Game");
    }
    private void OnTriggerEnter(Collider other){
            Destroy(gameObject);
            gameManager.GetComponent<GameManager>().CoinAdd();
    }
}
