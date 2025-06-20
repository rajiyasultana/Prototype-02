using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int coinCount = 0;
    public TextMeshProUGUI coinText;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddCoin(int value)
    {
        coinCount += value;
        Debug.Log("The total coin is " + coinCount);
        UpdateUI();
    }

    void UpdateUI()
    {
        if (coinText != null)
            coinText.text = "Coin: " + coinCount.ToString();
    }
}
