using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorScript : MonoBehaviour
{
    void Update ()
    {
        if (GameController.donutCount >=1)
        {
            TurnColor();
        }
    }

    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = col;
    }
}


