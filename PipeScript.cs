using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    private float moveSpeed = 13;
    private int deadZone = -45;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (  transform.position.x < deadZone )
        {
            Debug.Log( "Pipe destroyed" );
            Destroy( gameObject );
        }
    }


}
