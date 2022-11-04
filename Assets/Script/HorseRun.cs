using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEditor.U2D;
using UnityEngine;
using Random = UnityEngine.Random;

public class HorseRun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject board;
    public TextMeshProUGUI textBoard;
    float speed = 0.2f;
    float acceleration;
    bool start = false;
    Animator aniHorse;
    bool check = true;
    int trigger = 0;
    float time = 0;

    void Start()
    {
        random();
        aniHorse = GetComponent<Animator>();
        aniHorse.SetBool("Run", false);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 horsePosition = transform.position;
        if (Input.GetMouseButtonDown(0))
        {
            start = true;
            aniHorse.SetBool("Run", true);
        }
        if (start == true)
        {
            time += Time.deltaTime;
            horsePosition.x += speed + acceleration;
            transform.position = horsePosition;
        }
        //if (480 - transform.position.x <= 0 && check == true)
        if (trigger == 8 && check == true)
        {
            textBoard.text += gameObject.name + " - " + TimeSpan.FromSeconds(time).ToString("mm\\:ss\\.ff") + "\n";
            board.SetActive(true);
            check = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        trigger++;
        if (trigger >= 2)
        {
            random();
        }
    }
    float random()
    {
        acceleration = Random.Range(0.05f, 0.07f);
        return acceleration;
    }
}
