using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pildoras_2 : MonoBehaviour
{

    public GameObject prefabEdificio;
    public float randomRange = 2f;

    void Start()
    {
        InvokeRepeating("Pildora", 1f, 2.3f);
    }

    void Pildora()
    {
        Vector3 randomSpawn;
        randomSpawn.x = transform.position.x;
        randomSpawn.y = Random.Range(randomRange, -randomRange);
        randomSpawn.z = transform.position.z;

        Instantiate(prefabEdificio, randomSpawn, Quaternion.identity);
    }


}
