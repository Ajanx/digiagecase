using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sık: MonoBehaviour
{
    public float arttır;
    public Text text;
    public ates ates;
    public float buyumeFaktoru = 1.2f;
    public float kuculmeFaktoru = 0.2f;
    public float animasyonSure = 0.1f;

    private bool animasyonDevamEdiyor = false;
    private Vector3 ilkOlcek;

    public void OnTriggerEnter(Collider other)
    {

        if ((other.gameObject.tag == "mermigelsin")&& !animasyonDevamEdiyor)
        {
            arttır+=0.2f;
            animasyonDevamEdiyor = true;
            StartCoroutine(BoyutAnimasyonu(buyumeFaktoru));

        }
        if (other.gameObject.tag == "player")
        {
            print("debme");
            
            ates.atışAralığı -= arttır/10;

        }
    }
    public void Update()
    {
        text.text = arttır.ToString();
    }



    private void Start()
    {
        ilkOlcek = transform.localScale;
    }

 

    private IEnumerator BoyutAnimasyonu(float hedefFaktor)
    {
        float gecenSure = 0f;
        Vector3 hedefOlcek = ilkOlcek * hedefFaktor;

        while (gecenSure < animasyonSure)
        {
            gecenSure += Time.deltaTime;
            transform.localScale = Vector3.Lerp(ilkOlcek, hedefOlcek, gecenSure / animasyonSure);
            yield return null;
        }

        yield return new WaitForSeconds(animasyonSure);

        gecenSure = 0f;

        while (gecenSure < animasyonSure)
        {
            gecenSure += Time.deltaTime;
            transform.localScale = Vector3.Lerp(hedefOlcek, ilkOlcek, gecenSure / animasyonSure);
            yield return null;
        }

        transform.localScale = ilkOlcek;
        animasyonDevamEdiyor = false;
    }
}
