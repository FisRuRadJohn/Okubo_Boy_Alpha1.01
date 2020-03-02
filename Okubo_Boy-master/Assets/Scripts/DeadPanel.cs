using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeadPanel : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    public void PlayPulse()

    {
        SceneManager.LoadScene("Juego");
        // StartCoroutine(EsperarPlay());

    }

    public void ExitButton()
    {
        // StartCoroutine(EsperarVolver());
        SceneManager.LoadScene("MainMenu");
    }

   /* IEnumerator EsperarPlay()
    {
        yield return new WaitUntil(() => audioSource.isPlaying == false);
        SceneManager.LoadScene("Juego");
        
    }
    IEnumerator EsperarVolver()
    {
        yield return new WaitUntil(() => audioSource.isPlaying == false);
        SceneManager.LoadScene("MainMenu");
    }
    */

}
