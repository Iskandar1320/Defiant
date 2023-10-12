using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcultarHealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject barra;

    void Start()
    {
       
        barra.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
