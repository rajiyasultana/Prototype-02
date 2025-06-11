using UnityEngine;

public class Dropper : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        float time = Time.time;
        Debug.Log(time);
        if(time >= 3)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
