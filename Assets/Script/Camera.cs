using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject target;
    Vector3 cameraOffset;
    void Start()
    {
        target = GameObject.Find("horse6");
        cameraOffset = new Vector3(14.2f, 23.2f, -34.2f);
    }
    void Update()
    {
        transform.position = target.transform.position + cameraOffset;
    }
}
