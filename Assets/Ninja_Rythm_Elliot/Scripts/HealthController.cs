using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public int playerHealth = 3;
    public GameObject canvasLose;
    public GameObject canvasScore;
    public GameObject songmanager;
    public AudioSource _audio;

    [SerializeField] private Image[] hearts;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void Update()
    {
        GameOver();
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        for (int i = 0; i < hearts.Length; i++) 
        {
            if(i < playerHealth)
            {
                hearts[i].color = Color.red;
            }
            else
            {
                hearts[i].color= Color.black;
            }
        }
    }

    public void GameOver()
    {
        if(playerHealth == 0)
        {
            //Time.timeScale = 0;
            _audio.Pause();
            canvasLose.SetActive(true);
            //canvasScore.SetActive(false);
            songmanager.SetActive(false);
        }
    }

    public void Continue()
    {
        playerHealth = 3;
        _audio.Play();
        canvasLose.SetActive(false);
        //canvasScore.SetActive(true);
        songmanager.SetActive(true);

    }

    public void Retry()
    {
        Time.timeScale = 1f;
        string currentSceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene(currentSceneName);
    }
}
