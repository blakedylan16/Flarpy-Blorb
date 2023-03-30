using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject cloud;

    public float spawnRate;
    public float heightOffset;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate ( cloud, Transform.Transform)
        spawnCloud();
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
            spawnCloud();
            timer = 0;
        }
    }

    private void spawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;
            Instantiate( cloud, new Vector3( transform.position.x,
                    Random.Range ( lowestPoint, highestPoint ) ),
                    transform.rotation );
    
    }
}
