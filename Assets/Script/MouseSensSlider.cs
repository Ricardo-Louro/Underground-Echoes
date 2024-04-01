using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MouseSensSlider : MonoBehaviour
{
    public float defaultValue;

    private CameraMovement camMove;
    private Slider slider;

    [SerializeField] private TextMeshProUGUI tmp;

    // Start is called before the first frame update
    private void Start()
    {
        defaultValue = 2.0f;
        camMove = FindObjectOfType<CameraMovement>();
        slider = GetComponent<Slider>();
        UpdateText();
    }

    public void UpdateSensitivity()
    {
        camMove.mouseSensitivity = slider.value;
        UpdateText();
    }

    public void ResetSensitivity()
    {
        slider.value = defaultValue;
        UpdateSensitivity();
    }

    private void UpdateText()
    {
        tmp.text = Math.Round(slider.value, 1, MidpointRounding.AwayFromZero).ToString();
    }
}