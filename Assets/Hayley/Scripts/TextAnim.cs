using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextAnim : MonoBehaviour
{
    float speed = .05f;
    public bool fadeIn, fadeOut;
    TextMeshProUGUI tmp;

    // Start is called before the first frame update
    void Awake()
    {
        tmp = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(fadeOut)
        {
            if(tmp.color.a>0)
            {
                tmp.color -= new Color(0, 0, 0, speed);
            }
            else
            {
                tmp.color = new Color(tmp.color.r, tmp.color.g, tmp.color.b, 0);
                fadeOut = false;
            }
        }
        if (fadeIn)
        {
            if (tmp.color.a < 1)
            {
                tmp.color += new Color(0, 0, 0, speed);
            }
            else
            {
                tmp.color = new Color(tmp.color.r, tmp.color.g, tmp.color.b, 1);
                fadeIn = false;
            }
            //Debug.Log(tmp.color.a);
        }
    }
}
