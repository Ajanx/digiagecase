using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterkontrolleer : MonoBehaviour
{




    public float hareketHizi = 5f; // Hareket hýzý

    void Update()
    {
        HareketEt();
    }

    void HareketEt()
    {
        float yatayInput = Input.GetAxis("Horizontal"); // A ve D tuþlarý için yatay giriþi al

        // Hareket vektörünü oluþtur
        Vector3 hareket = new Vector3(yatayInput, 0f, 0f) * hareketHizi * Time.deltaTime;

        // Karakteri hareket ettir
        transform.Translate(hareket);
    }
}


