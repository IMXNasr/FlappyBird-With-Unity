using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public BirdScript bird;

    void Start(){
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }
    public void AddScore(int scoreToAdd = 1){
        if (bird.isAlive) {
            score += scoreToAdd;
            scoreText.text = score.ToString();
        }
    }
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver(){
        gameOverScreen.SetActive(true);
    }
}
