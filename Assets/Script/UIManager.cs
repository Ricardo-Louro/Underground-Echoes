using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI interactionMessage;
    [SerializeField] private GameObject optionsMenu;
    private CameraMovement camMove;
    private PlayerMovement playerMove;

    // Start is called before the first frame update
    private void Awake()
    {
        ClearInteractionMessage();
    }

    private void Start()
    {
        camMove = FindObjectOfType<CameraMovement>();
        playerMove = FindObjectOfType<PlayerMovement>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleOptionsMenu();
        }
    }

    public void UpdateInteractionMessage(string message)
    {
        interactionMessage.text = message;
    }

    public void ClearInteractionMessage()
    {
        interactionMessage.text = "";
    }

    private void ToggleOptionsMenu()
    {
        camMove.enabled = !camMove.enabled;
        playerMove.enabled = !playerMove.enabled;

        if (!camMove.enabled)
        {
            UnlockCursor();
        }

        optionsMenu.SetActive(!optionsMenu.activeSelf);
    }

    private void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
