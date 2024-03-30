using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class BrightnessSlider : MonoBehaviour
{
    [SerializeField] private Volume volume;
    private VolumeProfile profile;
    private Slider slider;
    private Vector4 gammaValue = new Vector4(1f,1f,1f,1f);

    private void Start()
    {
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
    }
}
