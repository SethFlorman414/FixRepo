﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decode : MonoBehaviour
{

    // Use this for initialization

    public GameObject decodeCanvas;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "CanvasTrigger")
        {

            decodeCanvas.SetActive(true);

        }

    }


    public void OnTriggerExit(Collider other)
    {


        if (other.gameObject.tag == "CanvasTrigger")
        {

            decodeCanvas.SetActive(false);

        }

    }
}
