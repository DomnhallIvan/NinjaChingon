using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            transform.position = Vector3.Lerp(transform.position, new Vector3
                (ray.direction.x * 15f, transform.position.y, transform.position.z), speed * Time.deltaTime);
        }
    }
}
