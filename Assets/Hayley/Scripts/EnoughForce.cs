using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnoughForce : MonoBehaviour
{
    public bool enoughForce;
    public GameObject firstPerson;
    public GameObject cursorAnim;
    public DragRotate rotator;
    public TextAnim text1, text2, text3, text4, text5;
    public Animator canvasAnim;
    public void Enough()
    {
        enoughForce = true;
        //text2.fadeIn = true;
    }


    public void Text1FadeIn()
    {
        text1.fadeIn = true;
    }
    public void Text1FadeOut()
    {
        text1.fadeOut = true;
    }
    //public void Text2FadeIn()
    //{
    //    text2.fadeIn = true;
    //}
    public void Text2FadeIn()
    {
        text2.fadeIn = true;
    }
    public void Text2FadeOut()
    {
        text2.fadeOut = true;
    }
    public void Text3FadeIn()
    {
        text3.fadeIn = true;
    }
    public void Text3FadeOut()
    {
        text3.fadeOut = true;
    }
    public void Text4FadeIn()
    {
        text4.fadeIn = true;
    }
    public void Text4FadeOut()
    {
        text4.fadeOut = true;
    }
    public void Text5FadeIn()
    {
        rotator.enabled = false;
        canvasAnim.enabled = true;
        firstPerson.SetActive(true);
        cursorAnim.SetActive(false);
        text5.fadeIn = true;
    }
    public void Text5FadeOut()
    {
        text5.fadeOut = true;
    }
}
