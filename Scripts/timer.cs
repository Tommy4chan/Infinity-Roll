using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static float tim;
    void Start(){
        tim = 0;
    }
    void Update(){
        tim += Time.deltaTime;
    }
}
