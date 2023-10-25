using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource music;

    private void Start()
    {
        music.volume = PlayerPrefs.GetFloat("MusicVolume");
    }
}
