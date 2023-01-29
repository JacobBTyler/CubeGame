using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class sliderToText : MonoBehaviour
{
    
    public Slider theSlider;
    public TextMeshProUGUI sliderText;

    public void FixedUpdate()
    {
        sliderText.text = theSlider.value.ToString("0");
    }
}
