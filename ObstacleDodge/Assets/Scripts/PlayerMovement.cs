using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");

        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue, 0f, zValue);
    }
}
