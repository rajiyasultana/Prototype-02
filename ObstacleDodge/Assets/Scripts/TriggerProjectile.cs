using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject triggerProjectile;

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            triggerProjectile.SetActive(true);
        }
    }
}
