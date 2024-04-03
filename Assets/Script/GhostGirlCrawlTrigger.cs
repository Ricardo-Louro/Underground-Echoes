using UnityEngine;

public class GhostGirlCrawlTrigger : MonoBehaviour
{
    [SerializeField] private GameObject ghostGirlCrawl;
    
    [SerializeField] private AudioSource audioSource1;
    [SerializeField] private AudioSource audioSource2;
    
    [SerializeField] private AudioClip clip1;
    [SerializeField] private AudioClip clip2;

    private new Collider collider;

    private void Start()
    {
        collider = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerMovement>() != null)
        {
            collider.enabled = false;

            ghostGirlCrawl.SetActive(true);
            audioSource1.PlayOneShot(clip1);
            audioSource2.PlayOneShot(clip2);
            Destroy(gameObject);
        }
    }
}