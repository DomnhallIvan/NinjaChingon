using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vinylRot : MonoBehaviour
{
    public Button miBoton;
    public float tiempoGiro = 3f;
    public float velocidadRotacion = 180f; 
    private bool girando = false;

    void Start()
    {
        miBoton.onClick.AddListener(Girar);
    }

    void Girar()
    {
        if (!girando)
        {
            girando = true;
            //miBoton.interactable = false;
            StartCoroutine(GirarBoton());
        }
    }

    IEnumerator GirarBoton()
    {
        float tiempoInicio = Time.time;
        while (Time.time < tiempoInicio + tiempoGiro)
        {
            miBoton.transform.Rotate(0f, 0f, velocidadRotacion * Time.deltaTime);
            yield return null;
        }
        //miBoton.interactable = true;
        girando = false;
    }
}





