using UnityEngine;

public abstract class Interactible : MonoBehaviour
{
    public abstract string interactionMessage { get; set; }
    public abstract void Interact();
}
