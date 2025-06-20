using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            ScoreManager.Instance.AddCoin(1);
            Destroy(gameObject);
        }
    }
}
