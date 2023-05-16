using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public List_Of_Effects Efectos;
    [SerializeField] private HealthController _healthController;

    private void Start()
    {
        Efectos = GameObject.FindObjectOfType<List_Of_Effects>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Notes"))
        {
            _healthController.playerHealth--;
            Destroy(other.gameObject);
            Efectos.Effects[3].Play();
            Efectos.Bruh();
        }
    }
}
