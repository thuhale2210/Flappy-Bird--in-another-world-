using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMoveScript : MonoBehaviour
{
    public GameObject arrow;
    public float arrowSpeed = 20.0f;
    public float arrowDeathZone = 50;

    void Start()
    {
        
    }

    void Update()
    {
        
        transform.position = transform.position + (Vector3.right * arrowSpeed) * Time.deltaTime;

        if (transform.position.x > arrowDeathZone)
        {
            Destroy(arrow);
        }
    }
}
