using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List_Of_Effects : MonoBehaviour
{
    
    public Text ScoreText;
    public Text NoteStatus;
    public int PlayerComboScore;

    public Image CoboImage;
    public Sprite[] ComboStoneImage;

    public ParticleSystem[] Effects;


    private void Start()
    {
        PlayerComboScore = 0;
        CoboImage.sprite = ComboStoneImage[0];
        
    }

    public void DeluxyCombo(int Combo)
    {
        PlayerComboScore += Combo;
        ScoreText.text = ("X " + PlayerComboScore);
        if (PlayerComboScore>=200)
        {
            CoboImage.sprite = ComboStoneImage[6];
        }
        else if(PlayerComboScore>=100)
        {
            CoboImage.sprite=ComboStoneImage[5];
        }
        else if (PlayerComboScore >= 50)
        {
            CoboImage.sprite = ComboStoneImage[4];
        }
        else if (PlayerComboScore >= 25)
        {
            CoboImage.sprite = ComboStoneImage[3];
        }
        else if (PlayerComboScore >= 10)
        {
            CoboImage.sprite = ComboStoneImage[2];
        }
        else if (PlayerComboScore >= 5)
        {
            CoboImage.sprite = ComboStoneImage[1];
        }
        
    }

    public void Bruh()
    {
        PlayerComboScore = 0;
        ScoreText.text = ("X " + PlayerComboScore);
        
            CoboImage.sprite = ComboStoneImage[0];
        

    }

   
}
