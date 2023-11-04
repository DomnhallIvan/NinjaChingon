using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActiveMaybe : MonoBehaviour
{
    public GameObject[] ObjetosIng;
    public GameObject[] ObjetosEsp;

    private void Start()
    {
        UpdateObject(GameLanguage.gl.currentLang);
    }
    // Update is called once per frame
    void Update()
    {
        if(GameLanguage.gl.currentLang)
        {
            UpdateObject(true);
        }
        else
        {
            UpdateObject(false);    
        }
       
    }

    void UpdateObject(bool currentLang)
    {
        if (currentLang)
        {
            foreach (GameObject obj in ObjetosIng)
            {
                obj.SetActive(true);
            }

            foreach (GameObject obj in ObjetosEsp)
            {
                obj.SetActive(false);
            }
        }
        else
        {
            foreach (GameObject obj in ObjetosIng)
            {
                obj.SetActive(false);
            }

            foreach (GameObject obj in ObjetosEsp)
            {
                obj.SetActive(true);
            }
        }
    }
}
