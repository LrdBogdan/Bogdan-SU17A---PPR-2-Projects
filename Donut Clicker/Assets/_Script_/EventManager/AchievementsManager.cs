using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsManager : MonoBehaviour
{
    public GameObject StarUI;
    public GameObject statusBar;
    public GameObject achievementPanel;

    //AchievementList
    public GameObject OnClickAchie;    //1
    public GameObject OnSoldAchie;     //2
    public GameObject OnFirstBuyAchie; //3
    public GameObject OnTonyAchie;     //4
    public GameObject OnBakedAchie;    //5

    public AudioSource achievementSound;

    void Awake()
    {
        Event_Manager.OnClicked += OnClickActive;
        Event_Manager.OnSold += OnSoldActive;
        Event_Manager.OnFirstBuy += OnFirstBuyActive;
        Event_Manager.OnTony += OnTonyActive;
        Event_Manager.OnBaked += OnBakedActive;
    }

    void OnClickActive()
    {
        OnClickAchie.SetActive(true);
        achievementSound.Play();
        statusBar.GetComponent<Text>().text = "Achievement: First Time Playing, huh?";
        statusBar.GetComponent<Animation>().Play("Anim Stat");
        achievementPanel.GetComponent<Animation>().Play("Anim Achie");
    }

    void OnFirstBuyActive()
    {
        OnFirstBuyAchie.SetActive(true); 
        achievementSound.Play();
        statusBar.GetComponent<Text>().text = "Achievement: Don't like labour!";
        statusBar.GetComponent<Animation>().Play("Anim Stat");
        achievementPanel.GetComponent<Animation>().Play("Anim Achie");
    }

    void OnSoldActive()
    {
        OnSoldAchie.SetActive(true);
        achievementSound.Play();
        statusBar.GetComponent<Text>().text = "Achievement: First Paycheck!";
        statusBar.GetComponent<Animation>().Play("Anim Stat");
        achievementPanel.GetComponent<Animation>().Play("Anim Achie");
    }

    void OnTonyActive()
    {
        OnTonyAchie.SetActive(true);
        achievementSound.Play();
        statusBar.GetComponent<Text>().text = "Achievement: The DoughFather ";
        statusBar.GetComponent<Animation>().Play("Anim Stat");
        achievementPanel.GetComponent<Animation>().Play("Anim Achie");
    }

    void OnBakedActive()
    {
        OnBakedAchie.SetActive(true);
        achievementSound.Play();
        statusBar.GetComponent<Text>().text = "Achievement: A Lard Lad!";
        statusBar.GetComponent<Animation>().Play("Anim Stat");
        achievementPanel.GetComponent<Animation>().Play("Anim Achie");
    }



}
