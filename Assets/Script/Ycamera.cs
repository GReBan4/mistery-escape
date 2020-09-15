﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ycamera : MonoBehaviour
{
    [SerializeField]
    private float y_sensitivity = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y_mouse = Input.GetAxis("Mouse Y");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.z -= y_mouse * y_sensitivity;
        transform.localEulerAngles = newRotation;
    }
}