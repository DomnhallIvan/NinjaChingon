using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NoteScoreManager : MonoBehaviour
{
    public TMP_Text ScoreText;
    [SerializeField] private LevelNumber lvNum;
    public int PlayerScore;
  
    // Start is called before the first frame update
    void Start()
    {
        PlayerScore = 0;       
        ScoreText.text = "" + PlayerScore;       
    }

    public void ChangeExScore(int Puntos)
    {
        PlayerScore = PlayerScore + Puntos;

        ScoreText.text = "" + PlayerScore;

        CheckHighScore();

    }

    //Mio
    public void FixedUpdate()
    {
       
       // Debug.Log(PlayerScore);
        //Debug.Log(PlayerPrefs.GetInt("HighScore"+levelNumber));
    }

    //Aqui digo si el PlayerScore es mayor al HighScore del nivel, entonces se pone un nuevo HighScore de ese nivel, y si no hay valor se pone 0 por default
    public void CheckHighScore()
    {
        //Debug.Log(PlayerScore);
       if(PlayerScore> PlayerPrefs.GetInt("HighScore"+lvNum.levelNumber))
        {
            PlayerPrefs.SetInt("HighScore"+lvNum.levelNumber, PlayerScore);
        }
    }
}