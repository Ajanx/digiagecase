using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class mermikovan : MonoBehaviour
{
    public float donmeHizi = 60f; 
    public int mermisayac;
    public GameObject mermi;
    public GameObject[] mermiler;
    public bool ilerle;
    public GameObject gidecekkovan;
    public Text sayac;
    public GameObject canvas;
    public AudioClip acd;
    public AudioSource audioSource;
    


    void Update()
    {
        sayac.text=mermisayac.ToString();
        
        if (mermisayac>= 6)
        {
            mermisayac = 6;
            transform.Translate(Vector3.up *5 * Time.deltaTime);
            Rigidbody rb;
            rb = GetComponent<Rigidbody>();
            canvas.SetActive(false);
            // Yer çekimini aç
            rb.useGravity = true;
        }

        if (transform.position.x<=-5.70f)
        {
            transform.Translate(Vector3.forward * 50*Time.deltaTime);
            mermisayac = 0;
            Instantiate(gidecekkovan, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
  
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
        Don();
        mermisayac++;
        mermiler[mermisayac].SetActive(true);
        audioSource.PlayOneShot(acd);
    }



    void Don()
    {

        transform.Rotate(Vector3.left, 60);
    }

   


   
}
