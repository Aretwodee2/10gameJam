using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Boards;
    private float xMin= -30f;
    private float xMax = -10f;
   
    private float yMin = 2.33f;
    private float yMax = 5.30f;

    float startDelay = 3;
    float spawnInterval = 5;

    //spawn location variables
    private float zMax = 17f;
    private float zMin = 2f;

    // Start is called before the first frame update
    void Start()
    {
        //spawning boards every 5 seconds with start delay timie at 3 seconds
        InvokeRepeating("SpawnBoards",startDelay,spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnBoards()
    {
        //setting the location range for boards to spawn
        Vector3 spawnPos = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), Random.Range(zMin,zMax));



        int boardIndex = Random.Range(0, Boards.Length);


        Instantiate(Boards[boardIndex], spawnPos, Boards[boardIndex].transform.rotation);




    }
}
