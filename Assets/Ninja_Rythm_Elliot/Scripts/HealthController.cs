using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public int playerHealth = 3;
    public float healthDecreaseSpeed = 1.0f; // Velocidad de disminución de la salud
    public GameObject canvasLose;
    public GameObject canvasScore;
    public GameObject songmanager;
    public AudioSource _audio;

    public Slider healthSlider;

    private int targetHealth; // Salud a la que se está moviendo gradualmente

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue = playerHealth;
        healthSlider.value = playerHealth;
        targetHealth = playerHealth;
    }

    private void Update()
    {
        GameOver();
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        // Gradualmente acércate a la nueva cantidad de salud
        playerHealth = (int)Mathf.Lerp(playerHealth, targetHealth, Time.deltaTime * healthDecreaseSpeed);
        healthSlider.value = playerHealth;
    }

    public void DecreaseHealth()
    {
        if (playerHealth > 0)
        {
            targetHealth -= 1;
        }
    }

    public void GameOver()
    {
        if (playerHealth <= 0)
        {
            //Time.timeScale = 0;
            _audio.Pause();
            canvasLose.SetActive(true);
            canvasScore.SetActive(false);
            songmanager.SetActive(false);
        }
    }

    public void Continue()
    {
        targetHealth = playerHealth = 3;
        _audio.Play();
        canvasLose.SetActive(false);
        canvasScore.SetActive(true);
        songmanager.SetActive(true);
    }

    public void Retry()
    {
        Time.timeScale = 1f;
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
