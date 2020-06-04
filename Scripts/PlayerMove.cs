using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public static float speed;
    public float sideForse;
    public float timer;
    void Start(){
        speed = 2000;
    }
    private void FixedUpdate(){
        if (timer > 0) {
            timer -= Time.deltaTime;
        }
        if(Input.GetKey("a")){
            playerRigidbody.AddForce(Vector3.left * sideForse * Time.deltaTime, ForceMode.VelocityChange);
        }
        if(Input.GetKey("d")){
            playerRigidbody.AddForce(Vector3.right * sideForse * Time.deltaTime, ForceMode.VelocityChange);
        }
        if(Input.GetKey("w")){
            playerRigidbody.AddForce(Vector3.forward * speed * Time.deltaTime);
        }
        if(Input.GetKey("s")){
            playerRigidbody.AddForce(Vector3.forward * -speed * Time.deltaTime);
        }
        if(Input.GetKey("space")){
            if(timer<0){
            playerRigidbody.AddForce(Vector3.up * 50000 * Time.deltaTime);
            timer = 2;
            }
        }
    
    }
}
