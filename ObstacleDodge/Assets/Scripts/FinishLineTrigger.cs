using UnityEngine;
using TMPro;

public class FinishLineTrigger : MonoBehaviour
{
    public GameObject finishPanel;
    public TextMeshProUGUI finishText;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            finishPanel.SetActive(true);
            finishText.text = "Coins: " + ScoreManager.Instance.coinCount.ToString();
            Time.timeScale = 0f; 
        }
    }
}
