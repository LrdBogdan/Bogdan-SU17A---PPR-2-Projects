using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutClickBehavior : MonoBehaviour
{
    public AudioSource biteSound;
    public GameObject textBox;



    public void ClickTheDonut()
    {
        biteSound.Play();
        textBox.SetActive(true);
        GameController.donutCount += 1;
        GameController.clickCount += 1;
    }
}
