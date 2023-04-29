using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ArrowSpawnScript : MonoBehaviour
{
    public GameObject arrow;
    public Transform objectToFollow;
    float spawnRate;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = Random.Range(3f, 7f);
        Invoke("spawnArrow", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnArrow();
            timer = 0;
        }
    }

    void spawnArrow()
    {
        Instantiate(arrow, new Vector3(transform.position.x, objectToFollow.position.y, 0), transform.rotation);
    }
}