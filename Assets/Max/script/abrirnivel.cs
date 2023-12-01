using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class abrirnivel : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Image LoadingBarFill;

    // Velocidad de llenado personalizada
    public float fillSpeed = 0.5f;

    public void CargarNivel(int Nombreniv)
    {
        StartCoroutine(LoadSceneAsync(Nombreniv));
    }

    IEnumerator LoadSceneAsync(int Nombreniv)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(Nombreniv);

        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);

            // Llenar la barra de carga hasta el 60%
            if (progressValue < 0.6f)
            {
                LoadingBarFill.fillAmount = progressValue;
            }

            // Esperar hasta que la carga esté completa
            else
            {
                // Llenar la barra de carga hasta el 100%
                LoadingBarFill.fillAmount += fillSpeed * Time.deltaTime;
            }

            yield return null;
        }

        // Puedes agregar aquí cualquier otra lógica que desees realizar después de cargar la escena.
    }
}
