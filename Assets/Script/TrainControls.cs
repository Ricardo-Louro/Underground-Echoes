using UnityEngine;

public class TrainControls : Interactible
{
    public override string interactionMessage { get; set; } = "Ride the train";

    public override void Interact()
    {
        Application.Quit();
    }
}
