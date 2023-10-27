using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public AudioSource music;
    public Image panelBrillo;

    private void Start()
    {
        music.volume = PlayerPrefs.GetFloat("MusicVolume");
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, PlayerPrefs.GetFloat("brillo"));
    }
}
