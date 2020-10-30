using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePattern;

    private float timeBtwSpawn;
    public  float startTimeBtwSpawn;
    public float decreaseTime;
    public float midTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePattern.Length);
            Instantiate(obstaclePattern[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if(startTimeBtwSpawn>midTime)
            startTimeBtwSpawn -= decreaseTime;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
