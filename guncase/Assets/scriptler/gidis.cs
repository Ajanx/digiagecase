using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gidis : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 y�n;
   public  mermikovan mermi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(y�n * 6 * Time.deltaTime);
    }

    
}
