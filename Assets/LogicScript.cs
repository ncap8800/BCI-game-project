using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public int playerLives = 3;
    public GameObject gameOverScreen;
    public bool playerIsAlive = true;
    public GameObject gameWinScreen;
    public GameObject wall;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        if (playerScore == 5)
            gameWin();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void reduceLife(int livesToReduce)
    {
        playerLives -= livesToReduce;
        if (playerLives == 2)
            Destroy(GameObject.FindGameObjectWithTag("LeftHeart"));
        else if(playerLives == 1)
            Destroy(GameObject.FindGameObjectWithTag("MiddleHeart"));
        else if(playerLives == 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("RightHeart"));
            gameOver();
            playerIsAlive = false;
        }            
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        Destroy(wall);
    }

    public void gameWin()
    {
        gameWinScreen.SetActive(true);
        Destroy(wall);
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
