using UnityEngine;

public class Football : MonoBehaviour
{
    private Rigidbody rb;

    private bool queueAddForce;

    private Transform playerTransform;
    [SerializeField] private float forceIntensity;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip clip;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        queueAddForce = false;
        playerTransform = FindObjectOfType<PlayerMovement>().transform;
    }

    public void TriggerFootballEvent()
    {
        queueAddForce = true;
    }

    private void FixedUpdate()
    {
        if(queueAddForce)
        {
            Vector3 force = (playerTransform.position - transform.position).normalized;
            rb.AddForce(force * forceIntensity);
            audioSource.PlayOneShot(clip);
            Destroy(this);
        }
    }
}
