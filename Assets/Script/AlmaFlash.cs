using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmaFlash : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioSource audioSource2;

    private new Collider collider;

    private void Start()
    {
        collider = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>() != null)
        {
            collider.enabled = false;

            animator.enabled = true;
            audioSource.Play();
            audioSource2.Play();
            Destroy(gameObject);
        }
    }
}