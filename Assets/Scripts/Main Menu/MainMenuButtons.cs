using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuButtons : MonoBehaviour
{
    private bool loadOpen;

    public Animator anim;

    public void StartNew()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Load()
    {
        if (!loadOpen)
        {
            anim.SetBool("loadOpen", true);
            loadOpen = true;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
