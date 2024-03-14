using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ates : MonoBehaviour
{
  
  
    //    public GameObject mermiPrefab;
    //    public Transform ateþNoktasý;
    //    public float atýþHýzý = 50f;
    public GameObject slide1;
    public GameObject slide2;
    public GameObject silah;
    private Vector3 currentPositionSlide1;
    private Vector3 currentPositionSlide2;

    

    public GameObject mermiPrefab; // Mermi prefab'ý
    public Transform ateþNoktasý; // Ateþ noktasý
    public float atýþHýzý = 10f; // Ateþ hýzý
    public float atýþAralýðý = 0.5f; // Ateþ aralýðý

    private float zamanlayici = 0f;

    void Update()
    {
        AtisKontrolu();
        currentPositionSlide1 = slide1.transform.position;
        currentPositionSlide2 = slide2.transform.position;
    }

    void AtisKontrolu()
    {
        zamanlayici += Time.deltaTime;


        if (zamanlayici >= atýþAralýðý)
        {
            AteþEt();
            
            zamanlayici = 0f; // Zamanlayýcýyý sýfýrla
        }
    }

    void AteþEt()
    {
     
        GameObject mermi = Instantiate(mermiPrefab, ateþNoktasý.position, ateþNoktasý.rotation);
        Rigidbody mermiRigidbody = mermi.GetComponent<Rigidbody>();
        mermiRigidbody.AddForce(ateþNoktasý.forward * atýþHýzý, ForceMode.Impulse);
        slide1.transform.position = new Vector3(currentPositionSlide1.x, currentPositionSlide1.y, currentPositionSlide1.z - 0.3f);
        Invoke("SlideMove", 0.05f);
    }
    void SlideMove()
    {

        slide1.transform.position = currentPositionSlide2;
    }
}
    

