using System;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using static Unity.Burst.Intrinsics.X86.Avx;

public class BrightnessSlider : MonoBehaviour
{
    public float defaultValue;

    [SerializeField] private Volume volume;
    private VolumeProfile profile;
    private Slider slider;
    private Vector4 gammaValue = new Vector4(1f,1f,1f,1f);

    [SerializeField] private TextMeshProUGUI tmp;

    private void Start()
    {
        defaultValue = 0f;
        profile = volume.profile;
        slider = GetComponent<Slider>();
    }

    public void UpdateBrightness()
    {
        if(!profile.TryGet<LiftGammaGain>(out var lgg))
        {
            lgg = profile.Add<LiftGammaGain>(false);
        }

        gammaValue.w = slider.value;
        lgg.gamma.value = gammaValue;


        tmp.text = Math.Round(slider.value, 1, MidpointRounding.AwayFromZero).ToString();
    }

    public void ResetBrightness()
    { }
        slider.value = defaultValue;
        UpdateBrightness();
    }
}