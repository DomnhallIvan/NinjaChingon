using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public bool inverse;
    public bool reverse;

    // Velocidades de desplazamiento independientes
    public float inverseScrollSpeed = 0.5f;
    public float reverseScrollSpeed = 0.5f;

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (inverse)
        {
            float offset = Time.time * inverseScrollSpeed;
            rend.material.mainTextureOffset = new Vector2(0, -offset);
        }
        else if (reverse)
        {
            float offset = Time.time * reverseScrollSpeed;
            rend.material.mainTextureOffset = new Vector2(0, offset);
        }
    }
}
