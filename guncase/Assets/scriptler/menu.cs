using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    
        // Sahne ad�n� belirle
  

        // D��meye t�klan�nca �a�r�lacak fonksiyon
        public void SahneYukle()
        {
            SceneManager.LoadScene(0);
        }
    public void SahneYukle1()
    {
        SceneManager.LoadScene(1);
    }


}
