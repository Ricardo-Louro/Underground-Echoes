using UnityEngine;

public class FootstepController : MonoBehaviour
{
    private AudioSource footstepSource;
    [SerializeField] private AudioClip footstepClip;
    [SerializeField] private Animator flashlightAnimator;
    [SerializeField] private float stepCooldown;
    private float lastTimeStepped;

    private void Start()
    {
        footstepSource = GetComponent<AudioSource>();
        lastTimeStepped = -stepCooldown;
    }
    // Update is called once per frame
    public void Footstep()
    {
        if(Time.time - lastTimeStepped >= stepCooldown)
        {
            footstepSource.pitch = Random.Range(0.8f, 1f);
            footstepSource.PlayOneShot(footstepClip);
            
            if(flashlightAnimator.gameObject.activeSelf)
            {
                flashlightAnimator.Play("FlashlightWalk");
            }
            
            lastTimeStepped = Time.time;
        }
    }
}
