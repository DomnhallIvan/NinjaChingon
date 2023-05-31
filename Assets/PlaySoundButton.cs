using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundButton : MonoBehaviour
{
    public AudioSource SoundKick;
    public AudioSource SoundMiss;
    // Start is called before the first frame update

    public void PLaythissound()
    {
        SoundKick.Play();
    }

    public void PLaySoundMiss()
    {
        SoundKick.Play();
    }

}
