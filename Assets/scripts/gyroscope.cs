using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroscope : MonoBehaviour
{
    public Camera player;

    // Use this for initialization
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.Rotate(-Input.gyro.rotationRateUnbiased.x * 2, -Input.gyro.rotationRateUnbiased.y * 2, -Input.gyro.rotationRateUnbiased.z * 2);
    }
}