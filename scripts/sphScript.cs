﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Mouvement des spheres
public class sphScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*Time.deltaTime* 0.2f);
    }
}
