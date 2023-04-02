using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    private int score;
    public Text scoreBoard;
    public Player playerScript;
    public GameObject gameOverPanel;
    public TextMeshProUGUI gameOverScoreBoard;

    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    public void addPoint()
    {
        //Debug.Log("add point");
        score++;
        setScoreboard(score);
    }

    public void killPlayer()
    { 
        //Debug.Log("Kill Player");
        playerScript.kill();
        gameOverScoreBoard.text = "Score " + score;
        gameOverPanel.SetActive(true);
    }

    void setScoreboard(int v)
    {
        scoreBoard.text = v.ToString();
    }
    
}
