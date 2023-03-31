using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// class that will control the movement mechanics of the bird as a whole
///     (including the wings).
/// also holds code that ends game on collision.
/// 
/// considering making camera bigger.
/// // 
/// </summary>
public class BirdScript : MonoBehaviour
{
    public int flapStrength;
    public Rigidbody2D myRigidBody;
    public LogicScript logic;
    public FlappingScript flapping;
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
        // when spacebar is hit, fly up
        if ( birdIsAlive && Input.GetKeyDown( KeyCode.Space ) )
        {
            flapping.flap();
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
        else if ( !birdIsAlive )
        {
            myRigidBody.Sleep();
        }
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
