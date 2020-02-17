using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadPanel : MonoBehaviour
{

    public void PlayPulse()
    {
        SceneManager.LoadScene("juego");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
