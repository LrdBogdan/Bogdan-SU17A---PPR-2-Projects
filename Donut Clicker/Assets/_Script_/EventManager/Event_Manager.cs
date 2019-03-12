using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Event_Manager : MonoBehaviour
{
    public delegate void ClickAction(); 
    public static event ClickAction OnClicked;     //1

    public delegate void SoldAction();
    public static event SoldAction OnSold;         //2

    public delegate void BestBuyAction();
    public static event BestBuyAction OnFirstBuy;  //3

    public delegate void FatTonyAction();
    public static event FatTonyAction OnTony;      //4

    public delegate void BakedAction();
    public static event BakedAction OnBaked;       //5

    public bool donutClicked = false;              //1
    public bool traderEarned = false;              //2
    public bool storeboughtClicked = false;        //3
    public bool tonyActivated = false;             //4
    public bool baked100 = false;                  //5

    public int currentDonuts;

    void Update()
    {
        currentDonuts = GameController.donutCount;
        TraderEarned();
        FatTony();
        DonutEarned();
    }

    public void DonutClick() //1
    {
        if (GameController.clickCount == 1 && donutClicked == false)
        {
            Debug.Log("OnClicked");
            OnClicked?.Invoke();
        }

        else
        {
            donutClicked = true;
        }
    }

    public void TraderEarned() //2
    {
        if (GameController.buckCount >= 1000 && traderEarned == false)
        {
            Debug.Log("OnSold");
            OnSold?.Invoke();
            traderEarned = true;
        }

    }

    public void BestBuy() //3
    {
        if (GameController.numberOfBakers == 1 && storeboughtClicked == false)
        {
            Debug.Log("OnFirstBuy");
            OnFirstBuy?.Invoke();

        }

        else
        {
            storeboughtClicked = true;
        }

        if (GameController.numberOfSellers == 1 && storeboughtClicked == false)
        {
             Debug.Log("OnFirstBuy");
            OnFirstBuy?.Invoke();
        }

        else
        {
            storeboughtClicked = true;
        }
    }

    public void FatTony() //4
    {
        if (StoreLog.tonyActive == true && tonyActivated == false)
        {
            Debug.Log("OnTony");
            OnTony?.Invoke();
        }

        else
        {
            tonyActivated = true;
        }
    }

    public void DonutEarned() //5
    {
        if (currentDonuts >= 100 && baked100 == false)
        {
            Debug.Log("OnBaked");
            OnBaked?.Invoke();
            baked100 = true;
        }
    }


}
