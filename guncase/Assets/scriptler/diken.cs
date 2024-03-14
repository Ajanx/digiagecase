using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diken : MonoBehaviour
{

    public float itmeMesafesi = 1f;
    public float itmeHizi = 5f;
    public karakterkontroller ka;
    public GameObject fx;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            fx.SetActive(true);
            changeyear.silahyear -= 10;
        }
    }


}
