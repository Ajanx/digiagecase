using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermiprefab : MonoBehaviour
{
    public GameObject mermiprefabx; 
    public float itmeHizi = 5f; 


    public float hedefPozisyonX = 1.0f; 
    public float kaydirmaHizi = 0.5f; 
    public int sayac;
    public GameObject kapý1;
    public GameObject kapý2;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "mermi")
        {
            spawnla();
            print("debeme");
            Destroy(other.gameObject);
        }
    }

    void KalemiSpawnEt()
    {

        GameObject yeniKalem = Instantiate(mermiprefabx, transform.position, Quaternion.identity);

        yeniKalem.transform.parent = transform;
    }

    void ItmeYap()
    {

        foreach (Transform child in transform)
        {
            child.Translate(-0.5f,0,0);
            Vector3 hedefPozisyon = new Vector3(hedefPozisyonX, child.position.y, child.position.z);


            child.position = Vector3.Lerp(child.position, hedefPozisyon, kaydirmaHizi * Time.deltaTime);

        }
    }
    public void spawnla()
    {
      
            
            StartCoroutine(sýkma());
           
           

            
        
    }

    IEnumerator sýkma()
    {
        for (int i = 0; i < 6; i++)
        {
            sayac++;
            print(sayac);
            ItmeYap();
            yield return new WaitForSeconds(0.1f);
           
            KalemiSpawnEt();
        }
            
        
    }
    private void Update()
    {
        if (sayac >= 6)
        {
            kapý1.SetActive(true);
        }
        if(sayac >= 12)
        {
            kapý2.SetActive(true);
        }
    }




}
