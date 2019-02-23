﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneAxisCamera : MonoBehaviour
{
    public Transform playerTransform;
    public bool isActivated;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isActivated)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,
                playerTransform.position.z);
        }

    }
}
