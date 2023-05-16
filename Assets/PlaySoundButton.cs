using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundButton : MonoBehaviour
{
    public AudioSource SoundButton;
    // Start is called before the first frame update

    public void PLaythissound()
    {
        SoundButton.Play();
    }
}
