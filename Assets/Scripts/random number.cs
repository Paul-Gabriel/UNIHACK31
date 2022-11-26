using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;

public class randomnumber : MonoBehaviour
{

    public float number, caz;
    public TextMeshPro text;
    private string x;

    private void Start()
    {
        text = GetComponentInChildren<TextMeshPro>();
        x = "Hello World";
        text.text = x;
    }
    void RandomNR()
    {
       
    }
    

 }
