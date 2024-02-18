using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buyukcember : MonoBehaviour
{
    public float speed;
    public bool kilit=false;
    public GameObject deadpanel;

    public Text scoretext;
    public int score = 0;

    void Start()
    {
        deadpanel.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)&&kilit==true)
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
            score = 0;
            kilit = false;
            deadpanel.SetActive(false);
        }
        
        transform.Rotate(0,0,speed*Time.deltaTime);
        
    }

    public void scoreplus()
    {
        scoretext.text = score.ToString();
        score = score + 1;
    }

    public void EndGame()
    {
        deadpanel.SetActive(true);
        Time.timeScale = 0;
        kilit=true;
        
       
    }
}
