using UnityEngine;
using UnityEngine.UI;

public class OptionsUIController : MonoBehaviour
{

    [SerializeField]
    private Toggle myToggle;
    [SerializeField]
    private Slider mySlider;
    void Start()
    {
        myToggle.onValueChanged.AddListener(OnMyToggleClick);
        mySlider.onValueChanged.AddListener(OnMySliderSlide);
        mySlider.minValue = 1;
        mySlider.maxValue = 100;
        mySlider.wholeNumbers = true;
    }
    private void OnMyToggleClick(bool value)
    {
        Debug.Log(value);
    }
    private void OnMySliderSlide(float slide)
    {
        Debug.Log(slide);
    }
}
