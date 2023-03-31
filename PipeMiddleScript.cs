using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public int scoreToAdd;
    public LogicScript logic;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag( "Logic" ).GetComponent< LogicScript >();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D( Collider2D collision )
    {
        if ( collision.gameObject.layer == 6 )
        {
            logic.addScore( 1 );
        }
        
        
    }
    
}
