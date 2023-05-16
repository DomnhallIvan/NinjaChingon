using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{

    public List_Of_Effects Efectos;
    [SerializeField] private Animator myAnimationController;
    [SerializeField] private HealthController _healthController;
    public PlaySoundButton _playS;

    private void Start()
    {
        Efectos = GameObject.FindObjectOfType<List_Of_Effects>();
        _playS = GameObject.FindObjectOfType<PlaySoundButton>();


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Notes"))
        {
            _healthController.playerHealth--;
            myAnimationController.Play("Fail");
            Destroy(other.gameObject);
            Efectos.Effects[3].Play();
            _playS.PLaySoundMiss();
            Efectos.Bruh();

        }
    }
}
