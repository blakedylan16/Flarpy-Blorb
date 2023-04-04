using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls movement of pipes.
/// </summary>
public class PipeScript : MonoBehaviour
{
    [ SerializeField ] private float moveSpeed = 12;
    [ SerializeField ] private int deadZone = -45;
    [ SerializeField ] private BirdScript bird;

    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag( "BirdLogic" )
            .GetComponent< BirdScript >();
    }

    // Update is called once per frame
    void Update()
    {
        // keeps moving as long as bird is alive
        if ( bird.getAliveStatus() )
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;

            if ( transform.position.x < deadZone )
            {
                Debug.Log( "Pipe destroyed");
                Destroy( gameObject );
            }
        }
    }


}
