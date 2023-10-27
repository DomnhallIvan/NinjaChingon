using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveButtons : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject CreditsPanel;
    public GameObject SettingsPanel;

    public void ActiveCredits()
    {
        StartPanel.SetActive(false);
        CreditsPanel.SetActive(true);
    }
    public void Desactive()
    {
       CreditsPanel.SetActive(false );
        SettingsPanel.SetActive(false);
        StartPanel.SetActive(true);
    }

    public void ActiveOptions()
    {
        StartPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }


}
