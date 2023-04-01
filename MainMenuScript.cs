using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{

    public void startGame()
    {
        SceneManager.LoadScene( "Active Game" );
        Debug.Log( "Scene changed" );
    }


}
