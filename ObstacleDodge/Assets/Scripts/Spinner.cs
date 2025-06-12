using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] int xRotation = 0;
    [SerializeField] int yRotation = 1;
    [SerializeField] int zRotation = 0;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xRotation, yRotation, zRotation);
    }
}
