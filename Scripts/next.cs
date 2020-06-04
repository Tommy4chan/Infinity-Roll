using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class next : MonoBehaviour
{
    public Text time;
    public Text Score;
    void Start(){
        time.text = "You survive for: " + timer.tim.ToString() + " s";
        Score.text = "Your score: " + GameManager.coin.ToString();
    }
    public void button(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
