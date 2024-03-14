using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterkontrolleer : MonoBehaviour
{




    public float hareketHizi = 5f; // Hareket h�z�

    void Update()
    {
        HareketEt();
    }

    void HareketEt()
    {
        float yatayInput = Input.GetAxis("Horizontal"); // A ve D tu�lar� i�in yatay giri�i al

        // Hareket vekt�r�n� olu�tur
        Vector3 hareket = new Vector3(yatayInput, 0f, 0f) * hareketHizi * Time.deltaTime;

        // Karakteri hareket ettir
        transform.Translate(hareket);
    }
}


