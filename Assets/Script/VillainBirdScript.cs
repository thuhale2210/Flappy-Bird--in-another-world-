using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillainBirdScript : MonoBehaviour
{
    public float villainSpeed = 10.0f;
    float upperReserveRange = 12;
    float lowerReverseRange = -13;

    void Update()
    {
        float pingPong = Mathf.PingPong(Time.time * villainSpeed, upperReserveRange - lowerReverseRange);
        float yPosition = pingPong + lowerReverseRange;
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
    }
}