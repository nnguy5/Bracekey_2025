using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{


    public Text AnnouncerTextLine1;
    public Text AnnouncerTextLine2;
    public Text Money;


    //public Slider[] healthSliders;

    public GameObject[] winIndicatorGrids;
    public GameObject winIndicator;




    public static LevelUI instance;
    public static LevelUI GetInstance()
    {
        return instance;
    }

    void Awake()
    {
        instance = this;
    }
    public void AddWinIndicator(int player)
    {
        GameObject fight = Instantiate(winIndicator, transform.position, Quaternion.identity) as GameObject;
        fight.transform.SetParent(winIndicatorGrids[player].transform);
    }
}
