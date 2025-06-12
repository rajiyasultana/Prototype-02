using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float flySpeed = 0.01f;

    Vector3 playerPosition;
    void Start()
    {
        playerPosition = player.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, flySpeed);
    }
}
