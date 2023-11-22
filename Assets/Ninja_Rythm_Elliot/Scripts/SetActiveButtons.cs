using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveButtons : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject CreditsPanel;
    public GameObject SettingsPanel;
    public GameObject SongsPanel;

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
        SongsPanel.SetActive(false);
    }

    public void ActiveOptions()
    {
        StartPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }

    public void ActiveSongs()
    {
        StartPanel.SetActive(false);
        SongsPanel.SetActive(true);
    }


}
