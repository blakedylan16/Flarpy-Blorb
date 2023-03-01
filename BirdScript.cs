using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// class that will control the movement mechanics of the bird as a whole
///     (including the wings).
/// also holds code that ends game on collision.
/// </summary>
public class BirdScript : MonoBehaviour
{
    public int flapStrength;
    public Rigidbody2D myRigidBody;
    private bool birdIsAlive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // when spacebar is hit, fly up
        if ( Input.GetKeyDown( KeyCode.Space ) )
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
