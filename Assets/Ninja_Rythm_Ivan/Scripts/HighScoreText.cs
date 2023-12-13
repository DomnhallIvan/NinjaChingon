using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highscoretext;
    [SerializeField] private LevelNumber lvNum;

    private void Start()
    {
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        //Aqui se cambia el texto seleccionado, dependiendo del level number que tenga, este sirve para saber cuál HighScore tiene que agarrar
        //highscoretext.text = $"HighScore:{PlayerPrefs.GetInt("HighScore" + levelNumber, 0)}";
        highscoretext.text=PlayerPrefs.GetInt("HighScore" + lvNum.levelNumber).ToString();
    }
}
