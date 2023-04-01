using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappingScript : MonoBehaviour
{
    public Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent< Animator >();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ ContextMenu( "Flap" ) ]
    public void flap()
    {
        myAnimator.SetTrigger( "Space" );
    }
}
