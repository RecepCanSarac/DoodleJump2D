using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("platform") || collision.gameObject.CompareTag("ziplaPlatform"))
        {
            collision.transform.position = new Vector3(Random.Range(-3, 4),transform.position.y + Random.Range(100, 101), collision.transform.position.z);
        }
    }
}
