using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject strawberry;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;


    bool gameStarted = false;

  
    


    void Update()
    {

        if(Input.GetMouseButtonDown(0) && !gameStarted){
            StartSpawning();
            gameStarted = true;
        }


    }

    private void StartSpawning(){
        InvokeRepeating("SpawnStrawberry", 0.5f, spawnRate);

    }

    private void SpawnStrawberry()
    {
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxX,  maxX );

        Instantiate(strawberry, spawnPos, Quaternion.identity);
    }






}
