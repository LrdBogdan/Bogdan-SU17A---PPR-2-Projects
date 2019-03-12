using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGoons : MonoBehaviour
{

    public bool eatingDonut = false;
    public int donutDecrease = 10;
    public int InternalDecrease;

    void Update()
    {
        InternalDecrease = donutDecrease;


        if (eatingDonut == false)
        {
            if (GameController.donutCount == 0)
            {
                StopCoroutine(Goon());
            }

            else
            {
                eatingDonut = true;
                StartCoroutine(Goon());
            }

        }
    }

    IEnumerator Goon()
    {
        GameController.donutCount -= InternalDecrease;
        yield return new WaitForSeconds(1);
        eatingDonut = false;
    }
}
