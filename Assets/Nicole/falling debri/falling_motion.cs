﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling_motion : MonoBehaviour
{
    //falling speed
    [SerializeField]
    private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
