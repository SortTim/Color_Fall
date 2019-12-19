using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class start : MonoBehaviour
{
    public Image boot;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        boot.canvasRenderer.SetAlpha(0.0f);

        fadeInEffect();
    }

    // Update is called once per frame
    void fadeInEffect()
    {
        boot.CrossFadeColor(Color.white, 10f, true, true);
        
    }
}