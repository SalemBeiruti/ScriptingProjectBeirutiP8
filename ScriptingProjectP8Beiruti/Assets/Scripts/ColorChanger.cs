using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Renderer> ().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Renderer>() .material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            GetComponent<Renderer>().material.color = Color.grey;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<Renderer>().material.color = Color.clear;
        }
    }
}
