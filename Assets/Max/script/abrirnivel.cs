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

    // Indica si la escena está cargada
    private bool isSceneLoaded = false;

    public void CargarNivel(int Nombreniv)
    {
        StartCoroutine(LoadSceneAsync(Nombreniv));
    }

    IEnumerator LoadSceneAsync(int Nombreniv)
    {
        LoadingScreen.SetActive(true);

        AsyncOperation operation = SceneManager.LoadSceneAsync(Nombreniv);

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);

            // Llenar la barra de carga hasta el 60%
            if (progressValue < 0.6f)
            {
                LoadingBarFill.fillAmount = progressValue;

                // Si la escena aún no está cargada, marca que está cargada al llegar al 60%
                if (!isSceneLoaded && progressValue >= 0.6f)
                {
                    isSceneLoaded = true;
                }
            }

            // Cuando la escena está cargada, llenar la barra de carga hasta el 100%
            else
            {
                LoadingBarFill.fillAmount += fillSpeed * Time.deltaTime;

                // Si la escena ya estaba cargada antes del 60%, cargarla cuando la barra llegue al 60%
                if (isSceneLoaded)
                {
                    if (LoadingBarFill.fillAmount >= 0.6f)
                    {
                        SceneManager.LoadScene(Nombreniv);
                        yield break;
                    }
                }

                // Si la escena se carga después del 60%, cargarla cuando la barra llegue al 100%
                else if (LoadingBarFill.fillAmount >= 1.0f)
                {
                    SceneManager.LoadScene(Nombreniv);
                    yield break;
                }
            }

            yield return null;
        }
    }
}
