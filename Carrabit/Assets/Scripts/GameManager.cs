using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score = 0;
    int lives = 3;
    bool gameOver;
    public Text ScoreText;
    public Text LivesText;
    public Text gameoverScoreText;

    public GameObject gameoverpanel;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncrementScore()
    { 
        if(!gameOver)
        {
            score++;
            ScoreText.text = score.ToString();
        //print(score);
        }
    }

    public void DecrementScore()
    {
        if(lives>0)
        {
            lives--;
            LivesText.text = lives.ToString();
            //print(lives);
        }
        if(lives <= 0)
        {
            gameOver = true;
            GameOver();
        }
       
    }
    public void GameOver()
    {
        
        CarrotSpawner.instance.StopSpawining();
        GameObject.FindWithTag("Player").GetComponent<PlayerScript>().isMove = false;
        gameoverpanel.SetActive(true);
        gameoverScoreText.text = score.ToString();
        
    }
}
