using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmaFlash : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>() != null)
        {
            animator.enabled = true;
            audioSource.PlayOneShot(clip);
            Destroy(gameObject);
        }
    }
}