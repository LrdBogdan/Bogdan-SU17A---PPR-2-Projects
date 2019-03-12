using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int savedDonuts;
    public int savedBucks;
    public int savedSellers;
    public int savedBakers;


    void Start()
    {
        if(MainSceneManagement.isLoading == true)
        {
            Debug.Log("Load Succesfull");

            savedDonuts = PlayerPrefs.GetInt("SaveDonutsData");
            GameController.donutCount = savedDonuts;
            savedBucks = PlayerPrefs.GetInt("SaveBucksData");
            GameController.buckCount = savedBucks;
            savedBakers = PlayerPrefs.GetInt("SavedBakers");
            GameController.numberOfBakers = savedBakers;
            savedSellers = PlayerPrefs.GetInt("SavedSellers");
            GameController.numberOfSellers = savedSellers;
        }
    }

}
