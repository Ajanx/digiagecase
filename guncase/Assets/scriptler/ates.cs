using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ates : MonoBehaviour
{
  
  
    //    public GameObject mermiPrefab;
    //    public Transform ate�Noktas�;
    //    public float at��H�z� = 50f;
    public GameObject slide1;
    public GameObject slide2;
    public GameObject silah;
    private Vector3 currentPositionSlide1;
    private Vector3 currentPositionSlide2;

    

    public GameObject mermiPrefab; // Mermi prefab'�
    public Transform ate�Noktas�; // Ate� noktas�
    public float at��H�z� = 10f; // Ate� h�z�
    public float at��Aral��� = 0.5f; // Ate� aral���

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


        if (zamanlayici >= at��Aral���)
        {
            Ate�Et();
            
            zamanlayici = 0f; // Zamanlay�c�y� s�f�rla
        }
    }

    void Ate�Et()
    {
     
        GameObject mermi = Instantiate(mermiPrefab, ate�Noktas�.position, ate�Noktas�.rotation);
        Rigidbody mermiRigidbody = mermi.GetComponent<Rigidbody>();
        mermiRigidbody.AddForce(ate�Noktas�.forward * at��H�z�, ForceMode.Impulse);
        slide1.transform.position = new Vector3(currentPositionSlide1.x, currentPositionSlide1.y, currentPositionSlide1.z - 0.3f);
        Invoke("SlideMove", 0.05f);
    }
    void SlideMove()
    {

        slide1.transform.position = currentPositionSlide2;
    }
}
    

