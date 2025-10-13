using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIControl : MonoBehaviour
{
    [SerializeField] TMP_Text titleText;
    [SerializeField] Toggle toggle1;
    [SerializeField] Slider slider;
    [SerializeField] Button btn;
    [SerializeField] TMP_Dropdown dropdown;
    void Start()
    {
        titleText.text = "This is Title";
    }

    public void OnToggle1Clicked()
    {
        Debug.Log("Clicked toggle1");
        if (toggle1.isOn)
        {
            Debug.Log("Toggle1 is on.");
        }
    }

    public void OnSliderClicked()
    {
        Debug.Log(slider.value);
    }

    public void OnBtnClicked()
    {
        Debug.Log("Button clicked!");
    }

    public void OnDropdownClicked()
    {
        Debug.Log(dropdown.value);
    }

    public void OnImageCliked()
    {
        Debug.Log("Clicked Image!!!!");
    }
}
