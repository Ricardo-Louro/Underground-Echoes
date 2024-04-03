using UnityEngine;

public class FootballTrigger : MonoBehaviour
{
    private Football football;
    
    private new Collider collider;

    private void Start()
    {
        collider = GetComponent<Collider>();
        football = FindObjectOfType<Football>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerMovement>() != null)
        {
            collider.enabled = false;

            football.TriggerFootballEvent();
            Destroy(gameObject);
        }
    }
}
