using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class AudioSlider : MonoBehaviour
{
    public float defaultValue;

    private Slider slider;

    [SerializeField] private TextMeshProUGUI tmp;

    // Start is called before the first frame update
    private void Start()
    {
        slider = GetComponent<Slider>();
        defaultValue = AudioListener.volume;
        slider.value = defaultValue;
        UpdateText();
    }

    public void UpdateAudio()
    {
        AudioListener.volume = slider.value;
        UpdateText();
    }

    public void ResetAudio()
    {
        slider.value = defaultValue;
        UpdateAudio();
    }

    private void UpdateText()
    {
        tmp.text = Math.Round(slider.value, 1, MidpointRounding.AwayFromZero).ToString();
    }
}