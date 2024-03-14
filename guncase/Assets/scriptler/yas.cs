using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class yas: MonoBehaviour
{
    public int arttır;
    public Text text;
    public float buyumeFaktoru = 1.2f;
    public float kuculmeFaktoru = 0.2f;
    public float animasyonSure = 0.1f;

    private bool animasyonDevamEdiyor = false;
    private Vector3 ilkOlcek;
    public GameObject fx;
    public void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "mermigelsin") && !animasyonDevamEdiyor)
        {
            arttır++;
            Destroy(other.gameObject);
            animasyonDevamEdiyor = true;
            StartCoroutine(BoyutAnimasyonu(buyumeFaktoru));

        }
        if (other.gameObject.tag == "player")
        {
            fx.SetActive(true);
            changeyear.silahyear += arttır;
            
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
