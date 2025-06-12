using Unity.Cinemachine;
using UnityEngine;

public class ObstacleHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.cyan;
            gameObject.tag = "Hit";
        }

    }
}
