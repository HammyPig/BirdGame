using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{   
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    void Start() {
        scoreText.text = playerScore.ToString();
    }

    [ContextMenu("addScore")]
    public void addScore(int score) {
        playerScore += score;
        scoreText.text = playerScore.ToString();
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
