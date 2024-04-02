using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScene : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip clip;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayTrainSound()
    {
        audioSource.PlayOneShot(clip);
    }

    public void SwitchSceneToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
