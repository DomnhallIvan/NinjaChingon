using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStructure : MonoBehaviour
{
    public List<GameObject> prefabs; // Lista de prefabs disponibles
    public Transform spawnPosition;
    public float spawnTimer = 1.0f;
    private float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTimer)
        {
            // Elegir un prefab al azar de la lista
            int randomPrefabIndex = Random.Range(0, prefabs.Count);
            GameObject selectedPrefab = prefabs[randomPrefabIndex];

            // Instanciar el prefab seleccionado
            GameObject spawnedObject = Instantiate(selectedPrefab, spawnPosition.position, Quaternion.identity);

            // Destruir el objeto después de 4 segundos
            Destroy(spawnedObject, 4.0f);

            timer = 0;
        }
    }
}


