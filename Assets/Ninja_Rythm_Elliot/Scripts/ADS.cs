using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ADS : MonoBehaviour
{
    public AdmobAdsScript admobAdsScript;
    public GameObject Image3;
    public GameObject Image2;
    public GameObject Image1;
    public GameObject Group;
    public GameObject Image4;
    public HealthController HealthController;

    public void StartTimeAds()
    {
        StartCoroutine(ADSTime());
    }

    public IEnumerator ADSTime()
    {
        admobAdsScript.LoadRewardedAd();
        admobAdsScript.ShowRewardedAd();
        Image3.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Image3.SetActive(false);
        Image2.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Image2.SetActive(false);
        Image1.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Image1.SetActive(false);
        Group.SetActive(true);
        Image4.SetActive(true);
        HealthController.ContinueADS();
    }


    public void ADSIntersitial()
    {
        admobAdsScript.LoadInterstitialAd();
        admobAdsScript.ShowInterstitialAd();
        
    }

}
