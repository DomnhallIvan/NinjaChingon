using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideMusic : MonoBehaviour
{
    public Slider audioSlider;
    public AudioSource Explosion;
    public float _timeanimationDie;
    public float _timeanimationExplosion;
    [SerializeField] private BossAnim _BossAnim;
    public List_Of_Effects Efectos;
    public GameObject canvasWinner;
    public GameObject canvasScore;


    private bool IsFinished = false;


    // Use this for initialization
    void Start()
    {
        audioSlider.direction = Slider.Direction.RightToLeft;
        audioSlider.minValue = 0;
        audioSlider.maxValue = GetComponent<AudioSource>().clip.length;
        GetComponent<AudioSource>().Play();
        _BossAnim = GameObject.FindObjectOfType<BossAnim>();
        Efectos = GameObject.FindObjectOfType<List_Of_Effects>();



    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(audioSlider.value);
        audioSlider.value = GetComponent<AudioSource>().time;
        Finish();
    }

    public void Finish()
    {

        if (audioSlider.value >= _timeanimationDie)
        {
            _BossAnim.Die();
        }

        if (audioSlider.value < _timeanimationExplosion)
        {
            //IsFinished = true;


            //Explosion.PlayOneShot(1);
            //IsFinished = false;
            // }

        }
        else
        {
            if (!IsFinished)
            {
                Efectos.Effects[4].Play();
                Explosion.Play();

            }
            IsFinished = true;
        }



        if (audioSlider.value >= 178)
        {
            canvasWinner.SetActive(true);
            canvasScore.SetActive(false);
        }


    }

}
