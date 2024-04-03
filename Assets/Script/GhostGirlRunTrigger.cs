using UnityEngine;

public class GhostGirlRunTrigger : MonoBehaviour
{
    [SerializeField] private GameObject ghostGirlRun;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip clip;

    private bool triggerDestroy;
    [SerializeField] private float timer;
    private float timeTriggered;

    private new Collider collider;

    // Start is called before the first frame update
    private void Start()
    {
        triggerDestroy = false;
        collider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerMovement>() != null)
        {
            collider.enabled = false;

            ghostGirlRun.SetActive(true);
            audioSource.PlayOneShot(clip);

            triggerDestroy = true;
            timeTriggered = Time.time;
        }
    }

    private void Update()
    {
        if(triggerDestroy)
        {
            if(Time.time - timeTriggered >= timer)
            {
                Destroy(ghostGirlRun);
                Destroy(gameObject);
            }
        }
    }
}