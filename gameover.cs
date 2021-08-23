using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float over = -25f;

        float now = this.transform.position.y;

        if (now <over){
            SceneManager.LoadScene("GameOver");
        }
    }
}
