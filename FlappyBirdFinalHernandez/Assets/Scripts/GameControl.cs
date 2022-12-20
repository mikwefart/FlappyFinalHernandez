using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public TMP_Text ScoreText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    private int score = 0;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void BirdScored()
    {
        if (gameOver)
            return;
        score++;
        ScoreText.text = "Score: " + score.ToString();
    }
    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
