using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static int clickCount;
    public int InternalClickCount;
    public static int donutCount;
    public int InternalDonutCount;
    public static int buckCount;
    public int InternalBuckCount;
    public static int numberOfBakers;
    public static int numberOfSellers;

    public bool GameIsPaused = false;
    public bool GameInStore = false;
    public bool GameInAchievement = false;

    public AudioSource storeChimeSound;

    public GameObject achieventScreenUI;
    public GameObject storeMenuUI;
    public GameObject pauseMenuUI;
    public GameObject sellerStats;
    public GameObject bakerStats;
    public GameObject buckDisplay;
    public GameObject donutDisplay;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        InternalClickCount = clickCount;
        InternalDonutCount = donutCount;
        InternalBuckCount = buckCount;

        bakerStats.GetComponent<Text>().text = "Active Bakers: " + numberOfBakers + "/4";
        sellerStats.GetComponent<Text>().text = "Active Sellers: " + numberOfSellers + "/4";

        donutDisplay.GetComponent<Text>().text = "Donuts: " + InternalDonutCount;
        buckDisplay.GetComponent<Text>().text = "Bucks: " + InternalBuckCount;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void EnterStore()
    {
        if (GameInStore)
        {
            storeMenuUI.SetActive(false);
        }

        else
        {
            storeChimeSound.Play();
            storeMenuUI.SetActive(true);
        }
    }

    public void EnterAchivement()
    {
        if (GameInAchievement)
        {
            achieventScreenUI.SetActive(false);
        }

        else
        {
            achieventScreenUI.SetActive(true);
        }
    }

    public void ExitAchivement()
    {
        if (GameInAchievement)
        {
            achieventScreenUI.SetActive(true);
        }

        else
        {
            achieventScreenUI.SetActive(false);
        }
    }

    public void ExitStore()
    {
        if (GameInStore)
        {
            storeMenuUI.SetActive(true);
        }

        else
        {
            storeMenuUI.SetActive(false);
        }
    }
}
