using UnityEngine;

public class Interaction : MonoBehaviour
{
    private Camera mainCamera;

    [SerializeField] private float maxInteractionDistance;

    private UIManager uiManager;

    // Start is called before the first frame update
    private void Start()
    {
        mainCamera = Camera.main;
        uiManager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.DrawLine(mainCamera.transform.position, mainCamera.transform.position + mainCamera.transform.forward * maxInteractionDistance, Color.red);
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out RaycastHit hit, maxInteractionDistance))
        {
            if(hit.collider.GetComponent<Interactible>() != null )
            {
                Interactible interactible = hit.collider.GetComponent<Interactible>();
                uiManager.UpdateInteractionMessage(interactible.interactionMessage);

                if(Input.GetMouseButtonDown(0))
                {
                    interactible.Interact();
                }
            }
            else
            {
                uiManager.ClearInteractionMessage();
            }
        }
        else
        {
            uiManager.ClearInteractionMessage();
        }
    }
}
