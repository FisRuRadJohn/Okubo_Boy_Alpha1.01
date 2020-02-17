using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pildoras : MonoBehaviour
{

    public float speed = 5f;

    void Start()
    {
        Invoke("Destroyer", 7f);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + speed * Time.deltaTime * Vector3.left;
    }

    private void Destroyer()
    {
        Destroy(gameObject);
    }
}
