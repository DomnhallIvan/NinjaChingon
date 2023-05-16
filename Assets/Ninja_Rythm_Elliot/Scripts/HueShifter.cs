using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HueShifter : MonoBehaviour
{
    public float Raibowspeed;
    public bool invert;
    public bool randomize;
    private MeshRenderer meshrenderer;

    private float hue;
    private float sat;
    private float bri;
    // Start is called before the first frame update
    void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
        if(randomize)
        {
            hue = Random.Range(0f, 1f);
        }
        sat = 1; 
        bri= 1;
        meshrenderer.material.color = Color.HSVToRGB(hue, sat, bri);
    }

    // Update is called once per frame
    void Update()
    {
        Color.RGBToHSV(meshrenderer.material.color, out hue, out sat, out bri);
        if(invert)
        {
            hue -= Raibowspeed / 10000;
            if(hue <= 0)
            {
                hue = 0.99f;
            }
        }
        else
        {
            hue += Raibowspeed / 10000;
            if (hue >= 1)
            {
                hue = 0;
            }
        }
        meshrenderer.material.color = Color.HSVToRGB(hue,sat,bri);

    }
}
