using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    private Material myMaterial;
    public float velocidadScroll;

    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        myMaterial.mainTextureOffset = myMaterial.mainTextureOffset + Vector2.right * velocidadScroll * Time.deltaTime;
    }
}

