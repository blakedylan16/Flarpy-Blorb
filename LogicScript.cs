using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    private int playerScore;
    private int highScore;
    public Text currentScoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public GameObject scoresToStart;
    public AudioSource bing;
    public AudioSource bong;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore");
        if ( highScore > 0 )
        {
            highScoreText.text = "High Score: " + highScore.ToString();
        }
        else
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
        if (playerScore > highScore)
        {
            highScore = playerScore;
            highScoreText.text = "High Score: " + highScore.ToString();
        }
        PlayerPrefs.SetInt("highScore", highScore);
    }


}
