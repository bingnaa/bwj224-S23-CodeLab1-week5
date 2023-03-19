using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTouch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("HIT: " + col.gameObject.name.Contains("Player"));
        
        if (col.gameObject.name.Contains("Player"))
        {
            GetComponent<AudioSource>().Play();
            GameManager.instance.GetComponent<ASCIILevelLoadScript>().ResetPlayer();
        }
    }
}
