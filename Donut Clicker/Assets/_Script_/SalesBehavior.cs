using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SalesBehavior : MonoBehaviour
{
    public GameObject statusBox;
    public AudioSource cachingSound;

    public void ClickTheDonut()
    {
        if(GameController.donutCount == 0)
        {
            statusBox.GetComponent<Text>().text = "Ain't got enough donut's man!";
            statusBox.GetComponent<Animation>().Play("Anim Stat");
        }

        else
        {
            cachingSound.Play();
            GameController.donutCount -= 1;
            GameController.buckCount += 5;
        }
    }
}
