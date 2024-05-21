using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool gameOver = false;
    int score = 0;

    public Text scoreText;
    public GameObject gameOverPanel;

    private void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        gameOver = true;

        GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning();

        gameOverPanel.SetActive(true);
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
            // print(score);
        }


    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}

