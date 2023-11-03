using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openPanel : MonoBehaviour
{
    public GameObject Panel;

    public void Panelopn()
    {
        if (Panel !=null)
        {
            Panel.SetActive(true);
        }
    }
    public void Panelclose()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
        }
    }

}
