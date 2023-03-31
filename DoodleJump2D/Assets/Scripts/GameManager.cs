using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text skorTXT;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skorTXT.text ="Skor: " + PlayerController.skor.ToString();
    }
}
