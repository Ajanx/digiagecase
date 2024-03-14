using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class enemy1 : MonoBehaviour
{
    public Text text;
    public GameObject canvas;
    public int sayac=12;
    public Transform exit;
    public Transform exit2;
    public GameObject fx;
    public GameObject fx1;
    public AudioClip ac;
    public AudioSource audioSource;
    public void OnTriggerEnter(Collider other)
    {

        if ((other.gameObject.tag == "mermigelsin"))
        {
            sayac--;
            Destroy(other.gameObject);
            Instantiate(fx1 ,exit.position,Quaternion.identity);
            audioSource.PlayOneShot(ac);
            

        }
        
    }
    private void Update()
    {
        text.text=sayac.ToString();
        if (sayac <= 0)
        {
            Destroy(canvas);
         
            Instantiate(fx, exit2.position, Quaternion.identity);
            Destroy(gameObject);

        }

    }
}
