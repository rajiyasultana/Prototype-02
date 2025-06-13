using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float flySpeed = 1f;

    Vector3 playerPosition;

    private void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.position;
    }

    void Update()
    {
        MoveTowardsPlayer();
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    void MoveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * flySpeed);
    }
}
