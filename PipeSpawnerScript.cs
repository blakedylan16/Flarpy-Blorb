using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;

    public float spawnRate;
    public float heightOffset;
    public BirdScript bird;

    private float timer = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag( "BirdLogic" ).GetComponent< BirdScript >();
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        
        if ( timer < spawnRate )
        {
            timer += Time.deltaTime;
        } else
        {
            spawnPipe();
            timer = 0;
        }
    }

    private void spawnPipe()
    {
        if (bird.getAliveStatus())
        {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;
            Instantiate(pipe, new Vector3(transform.position.x,
                    Random.Range(lowestPoint, highestPoint)),
                    transform.rotation);
        }
    }
}
