using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public GameObject obtionMenu;
    public GameObject mainMenu;
    public GameObject extrasMenu;
    public GameObject SkinMenu;

    public void PlayPulse()
    {
        SceneManager.LoadScene("Juego");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Options()
    {
        obtionMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void Volver()
    {
        mainMenu.SetActive(true);
        SkinMenu.SetActive(false);
        extrasMenu.SetActive(false);
        obtionMenu.SetActive(false);
    }

    public void Desbloqueables()
    {
        mainMenu.SetActive(false);
        SkinMenu.SetActive(true);
    }

    public void Extras()
    {
        mainMenu.SetActive(false);
        extrasMenu.SetActive(true);
    }
}
