using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public AudioClip mainMenu;
    public AudioClip slow;
    public bool bSlow = false;
    public bool startup = true;
    public GameObject blocks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startup)
        {
            transform.Rotate(0, 0, 1.5f);


            if (Input.touchCount > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                blocks.SetActive(true);
                startup = false;
                bSlow = true;
                GameObject.Find("Plane").GetComponent<AudioSource>().Stop();
                GameObject.Find("Player").GetComponent<AudioSource>().Play();
                
            }
        }


       
    }

   
}
