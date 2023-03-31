using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappingScript : MonoBehaviour
{
    //Animation flapping;
    Animator flapping;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ ContextMenu( "Flap" ) ]
    void flap()
    {
        flapping.Play();
    }
}
