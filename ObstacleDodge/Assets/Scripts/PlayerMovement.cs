using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5;
    
    void Start()
    {
        PrintInstructions();
    }

    
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!!");
        Debug.Log("Click ASDW to move player..");
        Debug.Log("Don't bump into any obstacle!!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xValue, yValue, zValue);
    }
}
