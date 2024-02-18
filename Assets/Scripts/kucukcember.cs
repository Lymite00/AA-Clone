using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class kucukcember : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public bool tuttumu;

    
    
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!tuttumu)
        {
            rb.MovePosition(rb.position+Vector2.up*speed*Time.deltaTime);
        }



        

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("buyukcember"))
        {
            transform.SetParent(other.transform);
            tuttumu = true;
            FindObjectOfType<buyukcember>().scoreplus();
        }
        else if (other.gameObject.CompareTag("kucukcember"))
        {
            FindObjectOfType<buyukcember>().EndGame(); 
        }
    }
}
