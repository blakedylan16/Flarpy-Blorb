using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// class that will control the movement mechanics of the bird as a whole
/// also holds code that ends game on collision.
/// </summary>
public class BirdScript : MonoBehaviour
{
    public int flapStrength;
    [ SerializeField ] private Rigidbody2D myRigidBody;
    [ SerializeField ] private LogicScript logic;
    [ SerializeField ] private FlappingScript flapping;
    private bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject
            .FindGameObjectWithTag( "Logic" )
            .GetComponent< LogicScript >();
        flapping = GameObject
            .FindGameObjectWithTag( "WingLogic" )
            .GetComponent< FlappingScript >();
    }

    // Update is called once per frame
    void Update()
    {
        // unless bird isn't alive, fly up when spacebar is hit
        if ( birdIsAlive && Input.GetKeyDown( KeyCode.Space ) )
        {
            flapping.flap();
            myRigidBody.velocity = Vector2.up * flapStrength;
        } else if ( !birdIsAlive )
        {
            myRigidBody.Sleep();
        }
        // kills bird when it flies out of bounds
        if ( transform.position.y > 15 || transform.position.y < -15 )
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }


    private void OnCollisionEnter2D( Collision2D collision )
    {
        logic.gameOver();
        birdIsAlive = false;
    }

    public bool getAliveStatus()
    {
        return birdIsAlive;
    }
}
