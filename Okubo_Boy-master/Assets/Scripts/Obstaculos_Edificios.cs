using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos_Edificios : MonoBehaviour
{

    public float speed = 5f;

    void Start()
    {
        Invoke("Destroyer", 7f);
    }

    
    void Update()
    {

        transform.position = transform.position + speed * Time.deltaTime * Vector3.left;
    }

    private void Destroyer()
    {
        Destroy(gameObject);
    }
}

