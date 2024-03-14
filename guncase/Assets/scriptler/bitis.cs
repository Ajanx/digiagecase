using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bitis : MonoBehaviour
{
    public GameObject fx;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            fx.SetActive(true);
        }
            
    }
}
