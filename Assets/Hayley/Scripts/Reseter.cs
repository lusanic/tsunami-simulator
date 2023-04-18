using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reseter : MonoBehaviour
{
    public float resetCoolDown;
    public bool canReset;
    float t;

    // Start is called before the first frame update
    void Start()
    {
        canReset = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.anyKey)
        {
            if (t < resetCoolDown)
                t += Time.deltaTime;
            else
                SceneManager.LoadScene(0);
        }
        else
        {
            t = 0;
        }
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
