using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CubeManager : MonoBehaviour
{
    public Slider lengthSlider;
    public Slider widthSlider;
    public Slider heightSlider;
    private float volume;
    private float edgelength;

    public GameObject lengthTextObject;
    public GameObject widthTextObject;
    public GameObject heightTextObject;
    public GameObject volumeTextObject;
    public GameObject edgelengthTextObject;

    private TextMeshProUGUI lengthText { get; set; }
    private TextMeshProUGUI widthText { get; set; }
    private TextMeshProUGUI heightText { get; set; }
    private TextMeshProUGUI volumeText { get; set; }
    private TextMeshProUGUI edgelengthText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        lengthText = lengthTextObject.GetComponent<TextMeshProUGUI>();
        widthText = widthTextObject.GetComponent<TextMeshProUGUI>();
        heightText = heightTextObject.GetComponent<TextMeshProUGUI>();
        volumeText = volumeTextObject.GetComponent<TextMeshProUGUI>();
        edgelengthText = edgelengthTextObject.GetComponent<TextMeshProUGUI>();

        CalculateGeometricProperties();
    }

    // Update is called once per frame
    void Update()
    {

       lengthText.text = "Cube Length: " + lengthSlider.value.ToString();
       widthText.text = "Cube Width: " + widthSlider.value.ToString();
       heightText.text = "Cube Height: " + heightSlider.value.ToString();
       volumeText.text = "Cube Volume: " + volume.ToString();
       edgelengthText.text = "Cube Edge Length: " + edgelength.ToString();
    }

    public void SliderChanged(float newValue)
    {
        CalculateGeometricProperties();
    }

    private void CalculateGeometricProperties()
    {
        volume = lengthSlider.value * widthSlider.value * heightSlider.value;
        edgelength = volume / (widthSlider.value * heightSlider.value);
    }
}