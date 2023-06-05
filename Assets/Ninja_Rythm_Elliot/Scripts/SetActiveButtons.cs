using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveButtons : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Buttons;
    public GameObject Start;
    public GameObject Name;
    public GameObject Creditspanel;
    public void ActiveB()
    {
        Buttons.SetActive(false);
        Start.SetActive(false);
        Name.SetActive(false);
        Panel.SetActive(true);
        Creditspanel.SetActive(true);
    }
    public void DesactiveB()
    {
        Buttons.SetActive(true);
        Start.SetActive(true);
        Name.SetActive(true);
        Panel.SetActive(false);
        Creditspanel?.SetActive(false);
    }

}
