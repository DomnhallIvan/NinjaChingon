using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List_Of_Effects : MonoBehaviour
{
    
    public Text ScoreText;
    public Text NoteStatus;
    public int PlayerComboScore;

    //public Image CoboImage;
    //public  List<string> TextoCombo= new List<string>();
    public Text Convo;
    public Text[] TextoCombo;

    public ParticleSystem[] Effects;

    private bool hasOkay = false;
    private bool hasOkay1 = false;
    private bool hasOkay2 = false;
    private bool hasOkay3 = false;
    private bool hasOkay4 = false;
    private bool hasOkay5 = false;
    private bool hasOkay6 = false;


    private void Start()
    {
        PlayerComboScore = 0;
        // ComboStoneImage[0].text;
        //Convo.text=TextoCombo[7].text;
        

    }

    public void DeluxyCombo(int Combo)
    {
        PlayerComboScore += Combo;
        ScoreText.text = ("X " + PlayerComboScore);
        if (PlayerComboScore>=200)
        {
            //Convo.text = TextoCombo[6].text;
            if (hasOkay5 == false)
            {
                hasOkay5 = true;
                LeanTween.scale(TextoCombo[6].gameObject, new Vector3(1.5f, 1.5f, 1.5f), 2f).setDelay(1.5f).setEase(LeanTweenType.easeOutElastic);
                LeanTween.scale(TextoCombo[6].gameObject, new Vector3(1f, 1f, 1f), 2f).setDelay(.5f).setEase(LeanTweenType.easeInOutCubic);
                LeanTween.scale(TextoCombo[6].gameObject, new Vector3(0f, 0f, 0f), 3f).setDelay(2.5f).setEase(LeanTweenType.easeInOutCubic);
            }
            
        }
        else if(PlayerComboScore>=100)
        {
            // Convo.text = TextoCombo[5].text;
            if (hasOkay4 == false)
            {
                hasOkay4 = true;
                LeanTween.scale(TextoCombo[5].gameObject, new Vector3(1.5f, 1.5f, 1.5f), 2f).setDelay(1.5f).setEase(LeanTweenType.easeOutElastic);
                LeanTween.scale(TextoCombo[5].gameObject, new Vector3(1f, 1f, 1f), 2f).setDelay(.5f).setEase(LeanTweenType.easeInOutCubic);
                LeanTween.scale(TextoCombo[5].gameObject, new Vector3(0f, 0f, 0f), 3f).setDelay(2.5f).setEase(LeanTweenType.easeInOutCubic);
            }
            
        }
        else if (PlayerComboScore >= 50)
        {
            // Convo.text = TextoCombo[4].text;
            if (hasOkay3 == false)
            {
                hasOkay3 = true;
                LeanTween.scale(TextoCombo[4].gameObject, new Vector3(1.5f, 1.5f, 1.5f), 2f).setDelay(1.5f).setEase(LeanTweenType.easeOutElastic);
                LeanTween.scale(TextoCombo[4].gameObject, new Vector3(1f, 1f, 1f), 2f).setDelay(.5f).setEase(LeanTweenType.easeInOutCubic);
                LeanTween.scale(TextoCombo[4].gameObject, new Vector3(0f, 0f, 0f), 3f).setDelay(2.5f).setEase(LeanTweenType.easeInOutCubic);
            }
            
        }
        else if (PlayerComboScore >= 20)
        {
            //Convo.text = TextoCombo[3].text;
            if(hasOkay2==false)
            {
                hasOkay2 = true;
                LeanTween.scale(TextoCombo[3].gameObject, new Vector3(1.5f, 1.5f, 1.5f), 2f).setDelay(1.5f).setEase(LeanTweenType.easeOutElastic);
                LeanTween.scale(TextoCombo[3].gameObject, new Vector3(1f, 1f, 1f), 2f).setDelay(.5f).setEase(LeanTweenType.easeInOutCubic);
                LeanTween.scale(TextoCombo[3].gameObject, new Vector3(0f, 0f, 0f), 3f).setDelay(2.5f).setEase(LeanTweenType.easeInOutCubic);
            }
            
        }
        else if (PlayerComboScore >= 10)
        {
            //Convo.text = TextoCombo[2].text;
            if(hasOkay1==false)
            {
                hasOkay1 = true;
                LeanTween.scale(TextoCombo[2].gameObject, new Vector3(1.5f, 1.5f, 1.5f), 2f).setDelay(1.5f).setEase(LeanTweenType.easeOutElastic);
                LeanTween.scale(TextoCombo[2].gameObject, new Vector3(1f, 1f, 1f), 2f).setDelay(.5f).setEase(LeanTweenType.easeInOutCubic);
                LeanTween.scale(TextoCombo[2].gameObject, new Vector3(0f, 0f, 0f), 3f).setDelay(2.5f).setEase(LeanTweenType.easeInOutCubic);
            }
            
        }
        else if (PlayerComboScore >= 5)
        {
           // Convo.text = TextoCombo[1].text;
           if(hasOkay==false)
            {
                hasOkay = true;
                LeanTween.scale(TextoCombo[1].gameObject, new Vector3(1.5f, 1.5f, 1.5f), 2f).setDelay(1.5f).setEase(LeanTweenType.easeOutElastic);
                LeanTween.scale(TextoCombo[1].gameObject, new Vector3(1f, 1f, 1f), 2f).setDelay(.5f).setEase(LeanTweenType.easeInOutCubic);
                LeanTween.scale(TextoCombo[1].gameObject, new Vector3(0f, 0f, 0f), 3f).setDelay(2.5f).setEase(LeanTweenType.easeInOutCubic);
            }
            
        }
        
    }

    public void Bruh()
    {
        PlayerComboScore = 0;
        ScoreText.text = ("X " + PlayerComboScore);

        //Convo.text = TextoCombo[0].text;
        if (hasOkay6 == false)
        {
            hasOkay6 = true;
            LeanTween.scale(TextoCombo[0].gameObject, new Vector3(1.5f, 1.5f, 1.5f), 1.5f).setDelay(1.5f).setEase(LeanTweenType.easeOutElastic);
            LeanTween.scale(TextoCombo[0].gameObject, new Vector3(1f, 1f, 1f), 2f).setDelay(.5f).setEase(LeanTweenType.easeInOutCubic);
            LeanTween.scale(TextoCombo[0].gameObject, new Vector3(0f, 0f, 0f), 3f).setDelay(2.5f).setEase(LeanTweenType.easeInOutCubic);
            Invoke(nameof(FalseAgain), 1f);
        }
    }

    private void FalseAgain()
    {
        hasOkay = false;
        hasOkay1 = false;
        hasOkay2 = false;
        hasOkay3 = false;
        hasOkay4 = false;
        hasOkay5 = false;
        hasOkay6 = false;


    }

}
