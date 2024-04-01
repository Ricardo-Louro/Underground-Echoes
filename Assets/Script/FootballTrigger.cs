using UnityEngine;

public class FootballTrigger : MonoBehaviour
{
    private Football football;

    private void Start()
    {
        football = FindObjectOfType<Football>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerMovement>() != null)
        {
            football.TriggerFootballEvent();
            Destroy(gameObject);
        }
    }
}
