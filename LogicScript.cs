using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    private int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject scoresToStart;
    public AudioSource bing;
    public AudioSource bong;



    [ ContextMenu( "Increase Score" ) ]
    public void addScore( int scoreToAdd )
    {
        bing.Play();
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    //public void startGame()
    //{
    //    SceneManager.LoadScene( "Active Game" );
    //    bing.Play();
    //}

    public void restartGame()
    {
        playerScore = 0;
        scoreText.text = playerScore.ToString();
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }

    public void gameOver()
    {
        bong.Play();
        gameOverScreen.SetActive( true );
    }


}
