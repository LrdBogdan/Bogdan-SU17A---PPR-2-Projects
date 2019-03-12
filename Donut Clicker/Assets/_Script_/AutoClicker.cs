using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    public bool bakingDonut = false;
    public int donutIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        InternalIncrease = donutIncrease;
        if (bakingDonut == false)
        {
            bakingDonut = true;
            StartCoroutine(DonutBaker());
        }
    }

    IEnumerator DonutBaker()
    {
        GameController.donutCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        bakingDonut = false;
    }
}
