using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NoteScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public float PlayerScore;
    // Start is called before the first frame update
    void Start()
    {
        PlayerScore = 0;
        ScoreText.text = "Score: " + PlayerScore;
    }

    
    public void ChangeExScore(float Puntos)
    {
        PlayerScore = PlayerScore + Puntos;
        ScoreText.text = "Score: " + PlayerScore;
    }
}
