using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeyear : MonoBehaviour
{
    // Start is called before the first frame update
    public static  int silahyear=1950;
    public int silahyýl;
    public GameObject silah1;
    public GameObject silah2;
    public GameObject silah3;   
    public GameObject silah4;
    public Text textyýl;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        silahyýl = silahyear;
        textyýl.text = silahyýl.ToString();
        if (silahyear > 1930 && silahyear < 1950)
        {
           
            
            silah1.SetActive(true);
            silah2 .SetActive(false);
            silah3.SetActive(false);
            silah4 .SetActive(false);
        }

        else if (silahyear > 1950 && silahyear < 1960)
        {
     
            
            silah1.SetActive(false);
            silah2.SetActive(true);
            silah3.SetActive(false);
            silah4.SetActive(false);
        }
        else if (silahyear > 1970 && silahyear < 1980)
        {
         
           
            silah1.SetActive(false);
            silah2.SetActive(false);
            silah3.SetActive(true);
            silah4.SetActive(false);
        }
        else if (silahyear > 1980)
        {

            
            silah1.SetActive(false);
            silah2.SetActive(false);
            silah3.SetActive(false);
            silah4.SetActive(true);
        }

        
    }

   
    
}
