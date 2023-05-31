using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public List_Of_Effects Efectos;
    [SerializeField] private HealthController _healthController;
    [SerializeField] private Animator myAnimationController;
    public PlaySoundButton _playS;

    private void Start()
    {
        Efectos = GameObject.FindObjectOfType<List_Of_Effects>();
        _playS = GameObject.FindObjectOfType<PlaySoundButton>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Notes"))
        {
            _healthController.playerHealth--;
            myAnimationController.Play("Fail");
            _playS.PLaySoundMiss();
            Destroy(other.gameObject);
            Efectos.Effects[3].Play();
            Efectos.Bruh();

        }
    }
}
