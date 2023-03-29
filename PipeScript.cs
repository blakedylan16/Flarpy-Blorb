using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    private float moveSpeed = 12;
    private int deadZone = -45;
    public BirdScript bird;

    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("BirdLogic").GetComponent< BirdScript >();
    }

    // Update is called once per frame
    void Update()
    {
        if ( bird.getAliveStatus() )
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;

            if (transform.position.x < deadZone)
            {
                Debug.Log("Pipe destroyed");
                Destroy(gameObject);
            }
        }
    }


}
