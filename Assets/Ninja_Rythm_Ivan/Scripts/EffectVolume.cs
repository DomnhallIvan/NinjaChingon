using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectVolume : MonoBehaviour
{
    public AudioSource soundEffect;

    // Start is called before the first frame update
    void Start()
    {
        soundEffect.volume = PlayerPrefs.GetFloat("FxVolume");
    }

    void Update()
    {

        
    }
}
