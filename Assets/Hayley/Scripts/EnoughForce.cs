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
    public GameObject locator12, locator3, locator4, locator5;

    public LineRendererController lrc;

    public void Enough()
    {
        enoughForce = true;
        //text2.fadeIn = true;
    }


    public void Text1FadeIn()
    {
        text1.fadeIn = true;
        locator12.SetActive(true);
        lrc.gameObject.SetActive(true);
        lrc.endPos = locator12.transform;
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
        locator12.SetActive(false);
    }
    public void Text3FadeIn()
    {
        text3.fadeIn = true;
        locator3.SetActive(true);
        lrc.endPos = locator3.transform;
    }
    public void Text3FadeOut()
    {
        text3.fadeOut = true;
        locator3.SetActive(false);
    }
    public void Text4FadeIn()
    {
        text4.fadeIn = true;
        locator4.SetActive(true);
        lrc.endPos = locator4.transform;
    }
    public void Text4FadeOut()
    {
        text4.fadeOut = true;
        locator4.SetActive(false);
    }
    public void Text5FadeIn()
    {
        rotator.enabled = false;
        firstPerson.SetActive(true);
        cursorAnim.SetActive(false);
        text5.fadeIn = true;
        //locator5.SetActive(true);
        //lrc.endPos = locator5.transform;
        lrc.gameObject.SetActive(false);
    }
    public void Text5FadeOut()
    {
        text5.fadeOut = true;
        //locator5.SetActive(false);
    }
}
