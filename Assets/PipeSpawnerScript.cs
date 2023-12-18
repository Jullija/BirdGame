using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
 
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){
            timer += Time.deltaTime;
        }else{
            spawnPipe();
            timer = 0;
        }
    }


    void spawnPipe(){

        float lowestPoint = transform.position.y - heightOffset;
        float highsetPoint = transform.position.y + heightOffset;


        //Instantiate for spawning objects
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highsetPoint), 0), transform.rotation);
    }


        
        
}
