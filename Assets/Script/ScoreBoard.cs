using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textBoard;
    float time = 0;
    [SerializeField] HorseRun[] horseRun = new HorseRun[12];
    bool check = true;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //time += Time.deltaTime;
        //for (int i = 0; i < horseRun.Count(); i++)
        //{
        //    if (480 - horseRun[i].transform.position.x <= 0)
        //    {
        //        Debug.Log(horseRun[i].name);
        //        textBoard.text = horseRun[i].name + " - " + TimeSpan.FromSeconds(time).ToString("mm\\:ss\\.ff") + "\n";
        //        board.SetActive(true);
        //    }
        //}
        float distance = 0;
        for (int i = 0; i < horseRun.Count(); i++)
        {
       //     if (480 - horseRun[i].transform.position.x)
        }
    }
}

