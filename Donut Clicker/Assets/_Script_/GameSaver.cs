using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSaver : MonoBehaviour
{
    public void SaveGame()
    {
        Debug.Log("Game Saved");

        PlayerPrefs.SetInt("SaveDonutsData", GameController.donutCount);
        PlayerPrefs.SetInt("SaveBucksData", GameController.buckCount);
        PlayerPrefs.SetInt("SavedBakers", GameController.numberOfBakers);
        PlayerPrefs.SetInt("SavedSellers", GameController.numberOfSellers);
    }
}
