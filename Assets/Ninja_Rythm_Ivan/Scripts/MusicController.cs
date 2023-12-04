using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public Slider volume;
    public Slider fxVolume;

    public AudioSource effectSource;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Iniciar en 50% si no hay valores almacenados en PlayerPrefs
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", 0.5f);
        }
        if (!PlayerPrefs.HasKey("FxVolume"))
        {
            PlayerPrefs.SetFloat("FxVolume", 0.5f);
        }

        volume.value = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
        fxVolume.value = PlayerPrefs.GetFloat("FxVolume", 0.5f);
    }
    // Update is called once per frame
    void Update()
    {
       
        if (audioSource != null)
        {
            audioSource.volume = volume.value;
        }

        if(effectSource!=null)
        {
            effectSource.volume = fxVolume.value;
        }
    }

    public void VolumePrefs()
    {
        PlayerPrefs.SetFloat("MusicVolume", volume.value);
        PlayerPrefs.SetFloat("FxVolume", fxVolume.value);
    }

}
