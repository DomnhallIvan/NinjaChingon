using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Say : MonoBehaviour
{
	
	public string defaultText = "Default Text";
	
	TextMeshProUGUI currentText;
	
    // Start is called before the first frame update
    void Start()
    {
        currentText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        currentText.text = GameLanguage.gl.Say(defaultText);
    }
	
}
