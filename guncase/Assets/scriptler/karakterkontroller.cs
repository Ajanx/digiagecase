using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterkontroller : MonoBehaviour
{
    public float hareketHizi = 5f; // Hareket h�z�
    public float geriyeCekmeMesafesi;
    void Update()
    {
        HareketEt();
        transform.Translate(Vector3.forward * 6 * Time.deltaTime);
    }

    void HareketEt()
    {
        float yatayInput = Input.GetAxis("Horizontal"); // A ve D tu�lar� i�in yatay giri�i al

        // Hareket vekt�r�n� olu�tur
        Vector3 hareket = new Vector3(yatayInput, 0f, 0f) * hareketHizi * Time.deltaTime;

        // Karakteri hareket ettir
        transform.Translate(hareket);
    }
    public void GeriyeGit()
    {
        Vector3 yeniPozisyon = transform.position - new Vector3(0f, 0f, geriyeCekmeMesafesi);
        transform.position = yeniPozisyon;
    }
}

