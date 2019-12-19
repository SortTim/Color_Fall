using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{

    public static float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5.0f;   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += this.transform.up * speed * Time.deltaTime;
    }
}
