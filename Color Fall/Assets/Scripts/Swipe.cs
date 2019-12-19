using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 directionX;
    public Vector2 directionY;
    public bool directionChosen;

    private GameObject player;

    public Material[] colorMat = new Material[4];


    private float timer;

    private void Start()
    {
       player = GameObject.Find("Player");
    }
    void Update()
    {
        // Track a single touch as a direction control.
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on touch phase.
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    startPos = touch.position;
                    directionChosen = false;
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                    directionX.x = touch.position.x - startPos.x;
                    directionY.y = touch.position.y - startPos.y;
                    break;

                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    directionChosen = true;
                    break;
            }


        }

      

        if (directionChosen)
        {
            if (directionY.y > 0 && Mathf.Sign(directionX.x) == 1)
            {
                Debug.Log("Up");
                player.GetComponent<Renderer>().material = colorMat[0];
                startPos = new Vector2(0, 0);
                directionX = new Vector2(0, 0);
                directionY = new Vector2(0, 0);

            }

            else if (directionY.y < 0 && directionX.x < 200)
            {
                Debug.Log("Down");
                player.GetComponent<Renderer>().material = colorMat[2];
                startPos = new Vector2(0, 0);
                directionX = new Vector2(0, 0);
                directionY = new Vector2(0, 0);

            }


            // Something that uses the chosen direction...
            else if (directionX.x < 0 && directionY.y < 200)
            {
                Debug.Log("Left");
                player.GetComponent<Renderer>().material = colorMat[3];
                startPos = new Vector2(0, 0);
                directionX = new Vector2(0, 0);
                directionY = new Vector2(0, 0);

            }

            else if (directionX.x > 0 && directionY.y < 200)
            {
                player.GetComponent<Renderer>().material = colorMat[1];
                Debug.Log("Right");
                startPos = new Vector2(0, 0);
                directionX = new Vector2(0, 0);
                directionY = new Vector2(0, 0);
            }

           
        }

        // This is super Scuff, But its time stuff winky face uwu skskkskkskskks help me 
        if (timer > 10)
        {
            this.gameObject.GetComponent<Renderer>().material = GameObject.FindGameObjectWithTag("plane").GetComponent<Renderer>().material;
        }
        if (!GameObject.Find("Player").GetComponent<Rotate>().startup)
        {
            timer += Time.deltaTime;
        }
    }
}
