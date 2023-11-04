using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisualizerScript : MonoBehaviour
{
    public float minHeight = 15.0f;
    public float maxHeight = 425.0f;
    public float updateSensitivity = 10.0f;
    public float volume = 1.0f; // Nuevo parámetro de volumen
    [Space(15)]
    public AudioClip audioClip;
    public bool loop = true;
    [Space(15), Range(64, 8192)]
    public int visualizerSimples = 64;

    public VisualizerObjectScript[] visualizerObjects;

    public Color[] colorGroups; // Array para almacenar los colores por grupos

    public AudioSource audioSource; // Usar el mismo AudioSource

    // Use this for initialization
    void Start()
    {
        visualizerObjects = GetComponentsInChildren<VisualizerObjectScript>();

        if (!audioClip)
            return;

        //audioSource = gameObject.AddComponent<AudioSource>(); // Usar el AudioSource del objeto actual
        audioSource.loop = loop;
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (audioSource == null)
            return;

        // Ajustar el volumen del audio
        audioSource.volume = PlayerPrefs.GetFloat("MusicVolume");

        float[] spectrumData = new float[visualizerSimples];
        audioSource.GetSpectrumData(spectrumData, 0, FFTWindow.Rectangular);

        for (int i = 0; i < visualizerObjects.Length; i++)
        {
            Vector2 newSize = visualizerObjects[i].GetComponent<RectTransform>().rect.size;

            newSize.y = Mathf.Clamp(Mathf.Lerp(newSize.y, minHeight + (spectrumData[i] * (maxHeight - minHeight) * 30.0f), updateSensitivity * 1f), minHeight, maxHeight);
            visualizerObjects[i].GetComponent<RectTransform>().sizeDelta = newSize;

            int colorGroupIndex = GetColorGroupIndex(i);
            visualizerObjects[i].GetComponent<Image>().color = colorGroups[colorGroupIndex];
        }
    }

    int GetColorGroupIndex(int index)
    {
        if (index >= 0 && index <= 1)
        {
            return 0; // Índices del 0 al 1 pertenecen al primer grupo de colores
        }
        else if (index >= 2 && index <= 4)
        {
            return 1; // Índices del 2 al 4 pertenecen al segundo grupo de colores
        }
        else if (index >= 5 && index <= 6)
        {
            return 2; // Índices del 5 al 6 pertenecen al tercer grupo de colores
        }
        else
        {
            return 0; // Por defecto, se asigna el primer grupo de colores
        }
    }
}
