using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 1;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Your score is " + score);
        score++;
    }
}
