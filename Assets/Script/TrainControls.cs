using UnityEngine;
using UnityEngine.SceneManagement;

public class TrainControls : Interactible
{
    public override string interactionMessage { get; set; } = "Ride the train";
    
    [SerializeField] private GameObject blackScreen;

    private PlayerMovement playerMove;
    private CameraMovement cameraMove;

    private void Start()
    {
        playerMove = FindObjectOfType<PlayerMovement>();
        cameraMove = FindObjectOfType<CameraMovement>();
    }

    public override void Interact()
    {
        playerMove.enabled = false;
        cameraMove.enabled = false;

        interactionMessage = "";
        blackScreen.SetActive(true);
    }
}
