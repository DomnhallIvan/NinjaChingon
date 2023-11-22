using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class abrirnivel : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Image LoadingBarFill;

    public void CargarNivel(int Nombreniv)
    {
        //SceneManager.LoadScene(Nombreniv);
        StartCoroutine(LoadSceneAsync(Nombreniv));
    }

    IEnumerator LoadSceneAsync(int Nombreniv)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(Nombreniv);

        LoadingScreen.SetActive(true);

        while(!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);

            LoadingBarFill.fillAmount = progressValue;

            yield return null;
        }
    }


}
