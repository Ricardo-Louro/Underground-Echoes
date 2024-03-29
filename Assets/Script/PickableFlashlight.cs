using UnityEngine;

public class PickableFlashlight : Interactible
{
    [SerializeField] private GameObject cameraFlashlight;
    public override string interactionMessage { get; set; } = "Pick up flashlight";

    public override void Interact()
    {
        cameraFlashlight.SetActive(true);
        Destroy(gameObject);
    }
}