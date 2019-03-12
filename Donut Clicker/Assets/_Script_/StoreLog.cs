using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreLog : MonoBehaviour
{
    public static bool tonyActive = false; //Used In "Event_Manager"
    public int currentMoney;
    public AudioSource woohooSound;

    public GameObject statusBar;

    //Buttons
    public Button MaggieButton, BartButton, LisaButton, MargeButton, RalphButton, HomerButton, ApuButton, TonyButton, SnakeButton;

    //Bakers
    public GameObject AutoClickerBart, AutoClickerLisa, AutoClickerMaggie, AutoClickerMarge;

    //Sellers
    public GameObject AutoSellerRalph, AutoSellerHomer, AutoSellerApu;

    //Goons
    public GameObject AutoGoonTony, AutoGoonSnake;

    void Update()
    {
        currentMoney = GameController.buckCount;
    }

    public void StartMaggie()
    {
        if (currentMoney >= 50)
        {
            woohooSound.Play();
            AutoClickerMaggie.SetActive(true);
            MaggieButton.interactable = false;
            GameController.numberOfBakers += 1;
            GameController.buckCount -= 50;
            statusBar.GetComponent<Text>().text = "You Bought It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }

        else
        {
            statusBar.GetComponent<Text>().text = "You Can't Afford It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }
    }

    public void StartBart()
    {
        if (currentMoney >= 200)
        {
            woohooSound.Play();
            AutoClickerBart.SetActive(true);
            BartButton.interactable = false;
            GameController.numberOfBakers += 1;
            GameController.buckCount -= 200;
            statusBar.GetComponent<Text>().text = "You Bought It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }

        else
        {
            statusBar.GetComponent<Text>().text = "You Can't Afford It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }
    }

    public void StartLisa()
    {
        if (currentMoney >= 550)
        {
            woohooSound.Play();
            AutoClickerLisa.SetActive(true);
            LisaButton.interactable = false;
            GameController.numberOfBakers += 1;
            GameController.buckCount -= 550;
            statusBar.GetComponent<Text>().text = "You Bought It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }

        else
        {
            statusBar.GetComponent<Text>().text = "You Can't Afford It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }
    }

    public void StartMarge()
    {
        if (currentMoney >= 1000)
        {
            woohooSound.Play();
            AutoClickerMarge.SetActive(true);
            MargeButton.interactable = false;
            GameController.numberOfBakers += 1;
            GameController.buckCount -= 1000;
            statusBar.GetComponent<Text>().text = "You Bought It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }

        else
        {
            statusBar.GetComponent<Text>().text = "You Can't Afford It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }
    }

    //Sellers\\

    public void StartRalph()
    {
        if (currentMoney >= 100)
        {
            woohooSound.Play();
            AutoSellerRalph.SetActive(true);
            RalphButton.interactable = false;
            GameController.numberOfSellers += 1;
            GameController.buckCount -= 100;
            statusBar.GetComponent<Text>().text = "You Bought It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }

        else
        {
            statusBar.GetComponent<Text>().text = "You Can't Afford It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }
    }

    public void StartHomer()
    {
        if (currentMoney >= 400)
        {
            woohooSound.Play();
            AutoSellerHomer.SetActive(true);
            HomerButton.interactable = false;
            GameController.numberOfSellers += 1;
            GameController.buckCount -= 400;
            statusBar.GetComponent<Text>().text = "You Bought It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }

        else
        {
            statusBar.GetComponent<Text>().text = "You Can't Afford It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }
    }

    public void StartApu()
    {
        if (currentMoney >= 1100)
        {
            woohooSound.Play();
            AutoSellerRalph.SetActive(true);
            ApuButton.interactable = false;
            GameController.numberOfSellers += 1;
            GameController.buckCount -= 1100;
            statusBar.GetComponent<Text>().text = "You Bought It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }

        else
        {
            statusBar.GetComponent<Text>().text = "You Can't Afford It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }
    }


    //Goons\\

    public void StartTony()
    {
        if (currentMoney >= 600)
        {
            tonyActive = true;
            woohooSound.Play();
            AutoGoonTony.SetActive(true);
            TonyButton.interactable = false;
            GameController.buckCount -= 600;
            statusBar.GetComponent<Text>().text = "You Bought It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }

        else
        {
            statusBar.GetComponent<Text>().text = "You Can't Afford It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }
    }

    public void StartSnake()
    {
        if (currentMoney >= 200)
        {
            woohooSound.Play();
            AutoGoonSnake.SetActive(true);
            SnakeButton.interactable = false;
            GameController.buckCount -= 200;
            statusBar.GetComponent<Text>().text = "You Bought It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }

        else
        {
            statusBar.GetComponent<Text>().text = "You Can't Afford It!";
            statusBar.GetComponent<Animation>().Play("Anim Stat");
        }
    }
}
