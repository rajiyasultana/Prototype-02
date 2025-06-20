using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int life = 3;
    public TextMeshProUGUI lifeText;          
    public GameObject gameOverPanel;


    private void Start()
    {
        UpdateLifeUI();
        gameOverPanel.SetActive(false);
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            life--;
            Debug.Log("Your life is " + life);
            UpdateLifeUI();

            if (life <= 0)
            {
                GameOver();
            }
        }
    }

    void UpdateLifeUI()
    {
        lifeText.text = "Life: " + life.ToString();
    }

    void GameOver()
    {
        gameOverPanel.SetActive(true);

        // Optional: Freeze the game
        Time.timeScale = 0f;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
