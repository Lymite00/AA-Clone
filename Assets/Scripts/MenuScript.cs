using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{

    public Button startB;
    public Button quitB;
    public Button itchB;
    public Button instagramB;
    
    
    void Start()
    {
        startB = GameObject.Find("StartButton").GetComponent<Button>();
        quitB = GameObject.Find("QuitButton").GetComponent<Button>();
        itchB = GameObject.Find("ItchButton").GetComponent<Button>();
        instagramB = GameObject.Find("IgButton").GetComponent<Button>();
        
        
        startB.onClick.AddListener(Sbutton);
        itchB.onClick.AddListener(Itchbutton);
        instagramB.onClick.AddListener(Igbutton);
        quitB.onClick.AddListener(QuitButton);
    }

   
    
    void Update()
    {
        
    }

    void QuitButton()
    {
        Application.Quit();
    }

    void Sbutton()
    {
        SceneManager.LoadScene(1);
    }

    void Igbutton()
    {
        Application.OpenURL("https://www.instagram.com/lymitedev/");
    }

    void Itchbutton()
    {
        Application.OpenURL("https://lymite.itch.io/");
    }
}
