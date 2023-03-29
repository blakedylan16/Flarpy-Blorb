using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;


    [ ContextMenu( "Increase Score" ) ]
    public void addScore( int scoreToAdd )
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        playerScore = 0;
        scoreText.text = playerScore.ToString();
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }

    public void gameOver()
    {
        gameOverScreen.SetActive( true );
    }
}
