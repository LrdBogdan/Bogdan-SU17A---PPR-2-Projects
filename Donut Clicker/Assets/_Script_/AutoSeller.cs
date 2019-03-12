using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSeller : MonoBehaviour
{
    public bool makingBucks = false;
    public int buckIncrease = 1;
    public int donutDecrease = 1;
    public int InternalIncrease;
    public int InternalDecrease;

    void Update()
    {
        InternalIncrease = buckIncrease;
        InternalDecrease = donutDecrease;


        if (makingBucks == false)
        {
            if (GameController.donutCount == 0)
            {
                StopCoroutine(DonutSeller());
            }

            else
            {
                makingBucks = true;
                StartCoroutine(DonutSeller());
            }
        
        }
    }

    IEnumerator DonutSeller()
    {
        GameController.donutCount -= InternalDecrease;
        GameController.buckCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        makingBucks = false;
    }
}
