using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(Rigibody2d))] para obligar a que exista un rigibody y que de no tenerlo el juego no se ejecute
public class Player_Okubo : MonoBehaviour
{
    public float JumpForce = 6.5f;
    Rigidbody2D miRigidbody;
    public static int puntuacion;
    public Text highScoreText;
    public Text textoPuntos;
    public AudioSource jump;
    public AudioSource hit;
    public AudioSource coin;
    public GameObject pildora;
    public GameObject gameOver;
    public static int highscore;
    public GameObject panelDead;
    public int contadorBarra;
    public Text contadorSaltos;
    public GameObject Barra1;
    public GameObject Barra2;
    public GameObject Barra3;
    public GameObject Barra4;
    public GameObject Barra5;


    private float tiempoMuerte = 0.1f;
    bool vivo;
   
    void Start()
    {
        contadorSaltos.text = contadorBarra.ToString();
        Time.timeScale = 1f;
        puntuacion = 0;
        miRigidbody = GetComponent<Rigidbody2D>();

        int highscore = PlayerPrefs.GetInt("scorehigh");
        highScoreText.text = highscore + "";
        vivo = true;
    }


    void Update()
    {
        if (vivo == true)
        {
            if (contadorBarra > 0)
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount == 1 && Input.touches[0].phase == TouchPhase.Began)
                {
                    miRigidbody.velocity = Vector2.up * JumpForce;

                    contadorBarra--;
                    contadorSaltos.text = contadorBarra.ToString();

                    jump.Play();
                }
            }
        }
        switch (contadorBarra)
        {
            case 0:
                Barra1.SetActive(false);
                Barra2.SetActive(false);
                Barra3.SetActive(false);
                Barra4.SetActive(false);
                Barra5.SetActive(false);
                break;
            case 1:
                Barra1.SetActive(true);
                Barra2.SetActive(false);
                Barra3.SetActive(false);
                Barra4.SetActive(false);
                Barra5.SetActive(false);

                break;
            case 2:
                Barra1.SetActive(true);
                Barra2.SetActive(true);
                Barra3.SetActive(false);
                Barra4.SetActive(false);
                Barra5.SetActive(false);
                break;
            case 3:
                Barra1.SetActive(true);
                Barra2.SetActive(true);
                Barra3.SetActive(true);
                Barra4.SetActive(false);
                Barra5.SetActive(false);
                break;
            case 4:
                Barra1.SetActive(true);
                Barra2.SetActive(true);
                Barra3.SetActive(true);
                Barra4.SetActive(true);
                Barra5.SetActive(false);
                break;
            case 5:
                Barra1.SetActive(true);
                Barra2.SetActive(true);
                Barra3.SetActive(true);
                Barra4.SetActive(true);
                Barra5.SetActive(true);
                break;

        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Point")) //para que solo pase el tema de desaparecer con los objetos que tengan el tag que le he concretado
        {
            coin.Play();
            puntuacion++;
            textoPuntos.text = puntuacion.ToString();
        }
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);  //hace que desaparezca el objeto cuando colisiona si tiene trigger   , si es un pick up, lo desactivo.

            contadorBarra++;
            contadorSaltos.text = contadorBarra.ToString();


        }




    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hit.Play();
       
        vivo = false;

        if (PlayerPrefs.GetInt("scorehigh") < puntuacion)
        {
            PlayerPrefs.SetInt("scorehigh", puntuacion);
        }

        panelDead.SetActive(true);
        
        Time.timeScale = tiempoMuerte;


    }

    
}