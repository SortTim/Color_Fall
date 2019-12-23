using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class collison : MonoBehaviour
{
    public Image gameover;
    public Transform plane;

    private int addS;
    private string convertS;
    public Text score;

    private void Start()
    {
        addS = 0;
    }

    // Temp stores instantaited stuff to die later kill me
    private Transform tempPlane;
    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.GetComponent<Renderer>().material);
        Debug.Log(this.gameObject.GetComponent<Renderer>().material);
        if (this.gameObject.GetComponent<Renderer>().material.name == col.gameObject.GetComponent<Renderer>().material.name)
        {
            Debug.Log("The world is in the right place");
            Destroy(col.gameObject);

            addS++;
            convertS = addS.ToString();
            score.text = convertS;


            //if (tempPlane != null)
            //  Destroy(tempPlane.gameObject);

            Transform newPlane;
            if (tempPlane == null)
                newPlane = Instantiate(plane, plane.transform.position, Quaternion.identity);
            else
                newPlane = Instantiate(plane, new Vector3(plane.transform.position.x, plane.transform.position.y, tempPlane.transform.position.z - 0.01f), Quaternion.identity);

            newPlane.GetComponent<Renderer>().material = this.gameObject.GetComponent<Renderer>().material;
            //Destroy(plane.gameObject);
            //newPlane.transform.parent = this.gameObject.transform;
            newPlane.transform.SetParent(gameObject.transform, true);
            tempPlane = newPlane;



            newPlane.GetComponent<Grow>().grow = true;
        }
        else
        {
            this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            this.gameObject.GetComponent<Renderer>().enabled = false;
            gameover.gameObject.SetActive(true);
        }
        
    }
}
