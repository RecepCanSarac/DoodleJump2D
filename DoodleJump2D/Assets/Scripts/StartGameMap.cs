using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameMap : MonoBehaviour
{
    public GameObject _platform;
    public int platformNum;
   
    void Start()
    {
        for (int i = 0; i < platformNum; i++)
        {
            float randomX = Random.Range(-3,4);
            float randomY = Random.Range(2,100);
            Instantiate(_platform,new Vector3(randomX,randomY,0f),Quaternion.identity);
        }
    }

   
}
