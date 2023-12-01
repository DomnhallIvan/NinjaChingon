using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public bool inverse;
    public bool reverse;
    // Scroll the main texture based on time

    float scrollSpeed = 0.5f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (inverse)
        {
            float offset = Time.time * scrollSpeed;
            rend.material.mainTextureOffset = new Vector2(0, - offset);
        }
        else if (reverse) 
        {
            float offset = Time.time * scrollSpeed;
            rend.material.mainTextureOffset = new Vector2(0, offset);
        }
        
    }
}
