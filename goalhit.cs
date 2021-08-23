using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goalhit : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        
            SceneManager.LoadScene("clear");
        
    }
}
