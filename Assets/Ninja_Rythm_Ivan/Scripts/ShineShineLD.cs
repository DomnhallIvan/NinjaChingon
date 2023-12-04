using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShineShineLD : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image panelBrillo;

    // Start is called before the first frame update
    void Start()
    {
        // Establecer el valor máximo y mínimo del slider
        slider.maxValue = 1f;
        slider.minValue = 0.2f;

        // Obtener el valor almacenado en PlayerPrefs o establecerlo en 1 si no existe
        slider.value = PlayerPrefs.GetFloat("brillo", 1f);

        // Configurar el valor del brillo y guardar en PlayerPrefs
        SetBrightness(slider.value);
    }

    public void ChangeSlider(float valor)
    {
        // Limitar el valor del slider al rango permitido (0.2 a 1)
        valor = Mathf.Clamp(valor, slider.minValue, slider.maxValue);

        // Actualizar la variable sliderValue con el nuevo valor del slider
        sliderValue = valor;

        // Configurar el valor del brillo y guardar en PlayerPrefs
        SetBrightness(sliderValue);
    }

    // Método para configurar el brillo y actualizar PlayerPrefs
    void SetBrightness(float value)
    {
        // Invertir el valor del slider para que 0.2 sea el brillo máximo y 1 sea el brillo mínimo
        float invertedValue = 1.0f - ((value - slider.minValue) / (slider.maxValue - slider.minValue));

        // Limitar el valor máximo del canal alpha al 80%
        float maxAlpha = 0.8f;
        invertedValue = Mathf.Clamp(invertedValue, 0f, maxAlpha);

        // Guardar el valor invertido en PlayerPrefs
        PlayerPrefs.SetFloat("brillo", invertedValue);

        // Configurar el color del panel de brillo utilizando el valor invertido del slider
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, invertedValue);
    }
}
