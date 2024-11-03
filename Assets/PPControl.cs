using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class PostProcessingControls : MonoBehaviour
{
    public PostProcessVolume postProcessVolume;
    private MotionBlur motionBlur;
    private DepthOfField depthOfField;
    private ColorGrading colorGrading;
    private Vignette vignette; 
    private Bloom bloom;

    public Button toggleMotionBlurButton;
    public Button toggleDepthOfFieldButton;
    public Button toggleColorGradingButton;
    public Button toggleVignetteButton;
    public Button toggleBloomButton; 

    private void Start()
    {
        postProcessVolume.profile.TryGetSettings(out motionBlur);
        postProcessVolume.profile.TryGetSettings(out depthOfField);
        postProcessVolume.profile.TryGetSettings(out colorGrading);
        postProcessVolume.profile.TryGetSettings(out vignette);
        postProcessVolume.profile.TryGetSettings(out bloom);

        toggleMotionBlurButton.onClick.AddListener(ToggleMotionBlur);
        toggleDepthOfFieldButton.onClick.AddListener(ToggleDepthOfField);
        toggleColorGradingButton.onClick.AddListener(ToggleColorGrading);
        toggleVignetteButton.onClick.AddListener(ToggleVignette);
        toggleBloomButton.onClick.AddListener(ToggleBloom);
    }

    private void ToggleMotionBlur()
    {
        if (motionBlur != null)
        {
            motionBlur.enabled.value = !motionBlur.enabled.value;
        }
    }

    private void ToggleDepthOfField()
    {
        if (depthOfField != null)
        {
            depthOfField.enabled.value = !depthOfField.enabled.value;
        }
    }

    private void ToggleColorGrading()
    {
        if (colorGrading != null)
        {
            colorGrading.enabled.value = !colorGrading.enabled.value;
        }
    }

    private void ToggleVignette()
    {
        if (vignette != null)
        {
            vignette.enabled.value = !vignette.enabled.value;
        }
    }

    private void ToggleBloom()
    {
        if (bloom != null)
        {
            bloom.enabled.value = !bloom.enabled.value;     
        }
    }
}
