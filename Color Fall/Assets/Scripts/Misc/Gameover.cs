using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Gameover : MonoBehaviour
{
    public Image gameover;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameover.canvasRenderer.SetAlpha(0.0f);

        fadeInEffect();
    }

    // Update is called once per frame
    void fadeInEffect()
    {
        gameover.CrossFadeAlpha(1, 2, false); 
    }

    private void Update()
    {

        if (timer > 2)
        {
            SceneManager.LoadScene("New Scene");
        }

        timer += Time.deltaTime;
    }
}
