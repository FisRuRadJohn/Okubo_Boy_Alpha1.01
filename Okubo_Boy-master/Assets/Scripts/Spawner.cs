using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefabEdificio;
    public float randomRange = 2f;

    void Start()
    {
        InvokeRepeating("Edificio", 1f, 2.3f);
    }

    void Edificio()
    {
        Vector3 randomSpawn;
        randomSpawn.x = transform.position.x;
        randomSpawn.y = Random.Range(randomRange, -randomRange);
        randomSpawn.z = transform.position.z;

        Instantiate(prefabEdificio, randomSpawn, Quaternion.identity);
    }


}