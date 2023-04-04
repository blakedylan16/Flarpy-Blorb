using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls flapping animation. Flaps when spacebar is hit
/// </summary>
public class FlappingScript : MonoBehaviour
{
    [ SerializeField ] public Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent< Animator >();
    }


    [ ContextMenu( "Flap" ) ]
    public void flap()
    {
        myAnimator.SetTrigger( "Space" );
    }
}
