using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject cloud;

    public float spawnRate;
    public float heightOffset;
    private float timer = 0;
    public float startingClouds;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < startingClouds; i++)
        {
            spawnCloud ( Random.Range ( -24, 22 ) );
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ( timer < spawnRate )
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCloud ( transform.position.x );
            timer = 0;
        }
    }

    private void spawnCloud ( float x, float y = 0 )
    {
        if ( y == 0 )
        {
            y = transform.position.y;
        }

        float lowestPoint = y - heightOffset;
            float highestPoint = y + heightOffset;
            Instantiate ( cloud, new Vector3( x,
                    Random.Range ( lowestPoint, highestPoint ) ),
                    transform.rotation );
    
    }
}
