using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arttırma : MonoBehaviour
{
    public int yıl;
    public GameObject fx;
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "player")
        {
            fx.SetActive(true);
            changeyear.silahyear += yıl;

        }
           
    }

}
