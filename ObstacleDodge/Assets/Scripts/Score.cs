using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 1;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            Debug.Log("Your score is " + score);
            score++;
        }
        else 
        {
            Debug.Log("Same box");
        
        }
        
    }
}
