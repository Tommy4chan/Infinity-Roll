using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text Score;
    public GameObject player1;
    public GameObject CameraF;
    public float RestartTime;
    public bool finish;
    public static int coin;
    public float timer = 5;
    public bool timerState;
    public static float speedAdd;
    void Start(){
        coin=0;
    }
    void Update(){
        if(timerState){
        if (timer > 0) {
            timer -= Time.deltaTime;
        }
        if (timer < 0) {
            PlayerMove.speed = 2000;
            timerState = false;
        }
        }
        if(player1.transform.position.y<-8){
            Restart();
        }


    }
    public void endGame(){
        Invoke("Restart", RestartTime);    
    }

    private void Restart(){
        CameraF.SetActive(true);
        speedAdd = 0;
    }
    public void CoinAdd(){
        coin++;
        Score.text = "Score: " + coin.ToString();
    }

    public void Speed(){
        PlayerMove.speed = 2800;
        timer = 5;
        timerState = true;
        
    }
    public void SpeedSlow(){
        PlayerMove.speed = 1000;
        timer = 5;
        timerState = true;
        
    }
}
