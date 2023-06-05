using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveButtons : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Buttons;
    public void ActiveB()
    {
        Buttons.SetActive(false);
        Panel.SetActive(true);
    }
    public void DesactiveB()
    {
        Buttons.SetActive(true);
        Panel.SetActive(false);
    }

}
