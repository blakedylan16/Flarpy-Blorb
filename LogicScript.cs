using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Class will control general logic of main game scene.
/// </summary>
public class LogicScript : MonoBehaviour
{
    private int playerScore;
    [ SerializeField ] private int highScore;

    [ SerializeField ] private Text currentScoreText;
    [ SerializeField ] private Text highScoreText;

    [ SerializeField ] public GameObject gameOverScreen;

    [ SerializeField ] private AudioSource bing;
    [ SerializeField ]private  AudioSource bong;

    private void Start()
    {
        // Gets saved high score. If high score = 0, displays nothing
        highScore = PlayerPrefs.GetInt( "highScore" );
        if ( highScore > 0 )
        {
            highScoreText.text = "High Score: " + highScore.ToString();
        } else
        {
            highScoreText.text = " ";
        }
    }

    [ ContextMenu( "Increase Score" ) ]
    public void addScore( int scoreToAdd )
    {
        bing.Play();
        playerScore += scoreToAdd;
        currentScoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        playerScore = 0;
        currentScoreText.text = " ";
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }

    public void gameOver()
    {
        bong.Play();
        gameOverScreen.SetActive( true );
        // changes highscore if applicable
        if (playerScore > highScore)
        {
            highScore = playerScore;
            highScoreText.text = "High Score: " + highScore.ToString();
        }
        PlayerPrefs.SetInt("highScore", highScore);
    }


}
