using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MazeManager : MonoBehaviour
{
    public bool isGamePlaying = false;

    private float levelTimer = 0f;

    public TMP_Text timerText;
    public TMP_Text finalTimeText;

    void Start()
    {
        StartGame();
    }

    void Update()
    {
        if (isGamePlaying)
        {
            levelTimer += Time.deltaTime;
            timerText.text = "Time: " + levelTimer.ToString("F2");
        }
    }

    public void StartGame()
    {
        levelTimer = 0f;
        isGamePlaying = true;

    }

    public void EndGame()
    {
        isGamePlaying = false;

        
        finalTimeText.text = "Final Time: " + levelTimer.ToString("F2");
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}