using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vinylRot : MonoBehaviour
{
    public Button miBoton;
    public float tiempoGiro = 10f;
    public float velocidadRotacion = -100f;
    private bool girando = false;
    public AudioSource audioSource;

    void Start()
    {
        miBoton.onClick.AddListener(Girar);
       
    }

    public void Girar()
    {
        if (!girando)
        {
            girando = true;
            audioSource.Pause(); 
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
        girando = false;
        audioSource.UnPause(); 
    }
}






