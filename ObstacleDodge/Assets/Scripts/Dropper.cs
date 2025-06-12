using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    MeshRenderer boxMeshRanderer;
    Rigidbody boxRigidbody;
    void Start()
    {
        boxMeshRanderer = GetComponent<MeshRenderer>();
        boxRigidbody = GetComponent<Rigidbody>();
        
        boxMeshRanderer.enabled = false;
        boxRigidbody.useGravity = false;
        
    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            boxMeshRanderer.enabled = true;
            boxRigidbody.useGravity = true;
        }
    }
}
