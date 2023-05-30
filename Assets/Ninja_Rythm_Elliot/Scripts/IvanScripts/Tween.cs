using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween : MonoBehaviour
{
    [SerializeField]

    GameObject levelSucces;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(levelSucces, new Vector3(1.5f, 1.5f, 1.5f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveLocal(levelSucces, new Vector3(-30f, 650f, 2f), .7f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(levelSucces, new Vector3(1f, 1f, 1f), 2f).setDelay(1.7f).setEase(LeanTweenType.easeInOutCubic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
