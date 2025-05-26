using NUnit.Framework;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsUIController : MonoBehaviour
{

    [SerializeField]
    private Toggle myToggle;
    [SerializeField]
    private Slider mySlider;
    [SerializeField]
    private TMP_Dropdown myDropDown;
    [SerializeField]
    private TMP_Text myText;
    [SerializeField]
    private Button myButton;
    [SerializeField]
    private GameObject startPanel;
    [SerializeField]
    private GameObject optionPanel;

    List<String> myList = new List<string>();
    void Start()
    {
        myButton.onClick.AddListener(OnMyButtonClicked);
        myToggle.onValueChanged.AddListener(OnMyToggleClick);
        mySlider.onValueChanged.AddListener(OnMySliderSlide);
        mySlider.minValue = 1;
        mySlider.maxValue = 100;
        mySlider.wholeNumbers = true;

        myDropDown.onValueChanged.AddListener(OnMyDropDownChanged);
    }
    private void OnMyToggleClick(bool value)
    {
        Debug.Log(value);
    }
    private void OnMySliderSlide(float slide)
    {
        Debug.Log(slide);
    }
    private void OnMyDropDownChanged(int arg0)
    {
        Debug.Log(myDropDown.options[arg0]);
    }
    private void OnMyButtonClicked()
    {
        startPanel.SetActive(true);
        optionPanel.SetActive(false);
    }
}
