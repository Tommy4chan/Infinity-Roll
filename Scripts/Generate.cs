using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject coin;
    public GameObject Ground;
    public GameObject Cube;
    public GameObject Player;
    public GameObject BoostUp;
    public GameObject BoostDown;
    public float xCube;
    public float yCube;
    public float yBoost = -72/10;
    public float zCube;
    public float playerPosA;
    public float playerPosB;
    public float Random;
    public float RandomBoost;
    public float yCoin = -89/10;
    float GroundSpawn = 700;
    void Start(){
        playerPosB = Player.transform.position.z;
        Random = UnityEngine.Random.Range(125, 136);
    }

    void Update(){
        playerPosA = Player.transform.position.z;
        if(playerPosB+Random < playerPosA+100){
            playerPosA = Player.transform.position.z;
            playerPosB = Player.transform.position.z;
            GenerateCube();
            GenerateCube();
            GenerateCube();
            GenerateBoost();
            Coin();
            Random = UnityEngine.Random.Range(125, 136);
        }
    if(playerPosA>GroundSpawn){
        Instantiate(Ground, new Vector3(0, -8, GroundSpawn+700), Quaternion.identity);
        GroundSpawn += 700;
    }

    }
    public void GenerateCube(){
        zCube = playerPosA + Random;
        xCube = UnityEngine.Random.Range(-10, 11);
        Instantiate(Cube, new Vector3(xCube, yCube, zCube), Quaternion.identity);
    }

    public void GenerateBoost(){
    RandomBoost = UnityEngine.Random.Range(0, 5);
        if(RandomBoost == 1){
            RandomBoost = UnityEngine.Random.Range(0, 2);
            if(RandomBoost == 1){
                xCube = UnityEngine.Random.Range(-10, 11);
                Instantiate(BoostUp, new Vector3(xCube, yBoost, zCube-15), Quaternion.identity);
            }
            else{
                xCube = UnityEngine.Random.Range(-10, 11);
                Instantiate(BoostDown, new Vector3(xCube, yBoost, zCube-15), Quaternion.identity);
            }
        }
    }
    public void Coin(){
        RandomBoost = UnityEngine.Random.Range(0, 5);
        if(RandomBoost == 1){
            RandomBoost = UnityEngine.Random.Range(0, 2);
            if(RandomBoost == 1){
                xCube = UnityEngine.Random.Range(-10, 11);
                Instantiate(coin, new Vector3(xCube, yCoin, zCube-10), Quaternion.identity);
            }
        }
    }
}
