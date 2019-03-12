using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainSceneManagement : MonoBehaviour
{
    public static bool isLoading = false;

    public void NewGame()
    {
        Debug.Log("Newbie");
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void LoadGame()
    {
        Debug.Log("Oldie");
        isLoading = true;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Debug.Log("D*D'd");
        Application.Quit();
    }

}
