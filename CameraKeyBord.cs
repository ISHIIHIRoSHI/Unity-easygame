using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKeyBord : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float z = 0f;
        float x = 0f;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            z = z + 0.1f;
            this.transform.Translate(0, 0, z);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            z = z - 0.1f;
            this.transform.Translate(0, 0, z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x += 0.1f;
            this.transform.Translate(x, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x -= 0.1f;
            this.transform.Translate(x, 0, 0);
        }
    }
}
