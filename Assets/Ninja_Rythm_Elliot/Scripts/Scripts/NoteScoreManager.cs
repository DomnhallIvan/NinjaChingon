using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NoteScoreManager : MonoBehaviour
{
    public TMP_Text ScoreText;
   
    public float PlayerScore;
  
    // Start is called before the first frame update
    void Start()
    {
        PlayerScore = 0;
       
        ScoreText.text = "Score " + PlayerScore;
       
    }

    
    public void ChangeExScore(float Puntos)
    {
        PlayerScore = PlayerScore + Puntos;
        
        ScoreText.text = "Score " + PlayerScore;
        
    }
}