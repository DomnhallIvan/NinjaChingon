using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideMusic : MonoBehaviour
{
    public Slider audioSlider;

    // Use this for initialization
    void Start()
    {
        audioSlider.direction = Slider.Direction.RightToLeft;
        audioSlider.minValue = 0;
        audioSlider.maxValue = GetComponent<AudioSource>().clip.length;
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        audioSlider.value = GetComponent<AudioSource>().time;
    }
}
