using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScrpt : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heigthOfSet = 10;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
        
    }

    void SpawnPipe()
    {
        float lowestPiont = transform.position.y - heigthOfSet;
        float highestPiont = transform.position.y + heigthOfSet;
        Instantiate(pipe, new Vector3(transform.position.x, 
            Random.Range(lowestPiont, highestPiont), 0), transform.rotation);
    }
}
