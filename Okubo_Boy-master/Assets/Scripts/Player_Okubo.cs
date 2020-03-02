using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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
    public AudioSource pildoraSound;
    public AudioSource music;

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
    public GameObject Barra6;
    public GameObject Barra7;
    public GameObject Barra8;
    public GameObject Barra9;
    public GameObject Barra10;

    private bool isJumping;
    private Animator anim;

    private float tiempoMuerte = 0.1f;
    bool vivo;
   
    void Start()
    {
        anim = GetComponent<Animator>();
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

                    anim.SetTrigger("Salto");

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
                Barra6.SetActive(false);
                Barra7.SetActive(false);
                Barra8.SetActive(false);
                Barra9.SetActive(false);
                Barra10.SetActive(false);
                break;
            case 1:
                Barra1.SetActive(true);
                Barra2.SetActive(false);
                Barra3.SetActive(false);
                Barra4.SetActive(false);
                Barra5.SetActive(false);
                Barra6.SetActive(false);
                Barra7.SetActive(false);
                Barra8.SetActive(false);
                Barra9.SetActive(false);
                Barra10.SetActive(false);
                break;
            case 2:
                Barra1.SetActive(true);
                Barra2.SetActive(true);
                Barra3.SetActive(false);
                Barra4.SetActive(false);
                Barra5.SetActive(false);
                Barra6.SetActive(false);
                Barra7.SetActive(false);
                Barra8.SetActive(false);
                Barra9.SetActive(false);
                Barra10.SetActive(false);
                break;
            case 3:
                Barra1.SetActive(true);
                Barra2.SetActive(true);
                Barra3.SetActive(true);
                Barra4.SetActive(false);
                Barra5.SetActive(false);
                Barra6.SetActive(false);
                Barra7.SetActive(false);
                Barra8.SetActive(false);
                Barra9.SetActive(false);
                Barra10.SetActive(false);
                break;
            case 4:
                Barra1.SetActive(true);
                Barra2.SetActive(true);
                Barra3.SetActive(true);
                Barra4.SetActive(true);
                Barra5.SetActive(false);
                Barra6.SetActive(false);
                Barra7.SetActive(false);
                Barra8.SetActive(false);
                Barra9.SetActive(false);
                Barra10.SetActive(false);
                break;
            case 5:
                Barra1.SetActive(true);
                Barra2.SetActive(true);
                Barra3.SetActive(true);
                Barra4.SetActive(true);
                Barra5.SetActive(true);
                Barra6.SetActive(false);
                Barra7.SetActive(false);
                Barra8.SetActive(false);
                Barra9.SetActive(false);
                Barra10.SetActive(false);
                break;
            case 6:
                Barra1.SetActive(true);
                Barra2.SetActive(true);
                Barra3.SetActive(true);
                Barra4.SetActive(true);
                Barra5.SetActive(true);
                Barra6.SetActive(true);
                Barra7.SetActive(false);
                Barra8.SetActive(false);
                Barra9.SetActive(false);
                Barra10.SetActive(false);
                break;
            case 7:
                Barra1.SetActive(true);
                Barra2.SetActive(true);
                Barra3.SetActive(true);
                Barra4.SetActive(true);
                Barra5.SetActive(true);
                Barra6.SetActive(true);
                Barra7.SetActive(true); 
                Barra8.SetActive(false);
                Barra9.SetActive(false);
                Barra10.SetActive(false);
                break;
            case 8:
                Barra1.SetActive(true);
                Barra2.SetActive(true);
                Barra3.SetActive(true);
                Barra4.SetActive(true);
                Barra5.SetActive(true);
                Barra6.SetActive(true);
                Barra7.SetActive(true);
                Barra8.SetActive(true);
                Barra9.SetActive(false);
                Barra10.SetActive(false);
                break;
            case 9:
                Barra1.SetActive(true);
                Barra2.SetActive(true);
                Barra3.SetActive(true);
                Barra4.SetActive(true);
                Barra5.SetActive(true);
                Barra6.SetActive(true);
                Barra7.SetActive(true);
                Barra8.SetActive(true);
                Barra9.SetActive(true);
                Barra10.SetActive(false);
                break;
            case 10:
                Barra1.SetActive(true);
                Barra2.SetActive(true);
                Barra3.SetActive(true);
                Barra4.SetActive(true);
                Barra5.SetActive(true);
                Barra6.SetActive(true);
                Barra7.SetActive(true);
                Barra8.SetActive(true);
                Barra9.SetActive(true);
                Barra10.SetActive(true);
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
            pildoraSound.Play();
            other.gameObject.SetActive(false);  //hace que desaparezca el objeto cuando colisiona si tiene trigger   , si es un pick up, lo desactivo.

            contadorBarra+=2;
            contadorSaltos.text = contadorBarra.ToString();


        }
        if (other.gameObject.CompareTag("PickUp2"))
        {
            pildoraSound.Play();
            other.gameObject.SetActive(false);  //hace que desaparezca el objeto cuando colisiona si tiene trigger   , si es un pick up, lo desactivo.

            contadorBarra += 1;
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