using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatefield : MonoBehaviour
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

        if (Input.GetKey(KeyCode.A))
        {
            z = z + 0.1f;
            this.transform.Rotate(0, 0, z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            z = z - 0.1f;
            this.transform.Rotate(0, 0, z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            x += 0.1f;
            this.transform.Rotate(x, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            x -= 0.1f;
            this.transform.Rotate(x, 0, 0);
        }
    }
}
