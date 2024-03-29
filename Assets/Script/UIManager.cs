using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private TextMeshProUGUI tmp;

    // Start is called before the first frame update
    private void Awake()
    {
        tmp = GetComponentInChildren<TextMeshProUGUI>();
        ClearInteractionMessage();
    }

    public void UpdateInteractionMessage(string interactionMessage)
    {
        tmp.text = interactionMessage;
    }

    public void ClearInteractionMessage()
    {
        tmp.text = "";
    }
}
