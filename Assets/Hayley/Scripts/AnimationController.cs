using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class AnimationController : MonoBehaviour
{
    [Header("References")]
    public Animator plateAnim;
    public Animator oceanAnim;
    public Animator arrowAnim;
    public Animator arrowAnim2;
    public Animator arrowAnim3;
    public Animator cursorAnim;
    public Animator sliderAnim;

    public float forceDuration = 7.11f;

    public Button simulateButton;
    public Slider progressBar;
    public bool stageOne = true;
    public bool finished = true;
    public bool pressed = true;

    public EnoughForce animBoolScript;
    public TMP_Text simulationButtonText;
    public Reseter res;
    public DragRotate rotator;

    public GameObject thirdPerson;
    public GameObject firstPerson;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCursorAnim());
    }

    
    // Update is called once per frame
    void Update()
    {
        
        if (pressed)
        {
            progressBar.value += Time.deltaTime * 10 / forceDuration;
        }
        //if (stageOne && plateAnim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        //{
        //    stageOne = false;
        //    //arrowAnim.SetBool("StageTwo", true);
        //    //oceanAnim.enabled = true;
        //}
        if (stageOne && animBoolScript.enoughForce)
        {
            stageOne = false;
            plateAnim.speed = 0;
            simulationButtonText.text = "Release";
            //arrowAnim.SetBool("StageTwo", true);
            //oceanAnim.enabled = true;
        }
        if (oceanAnim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        {
            finished = true;
        }
        if (finished)
        {
            finished = false;
            ResetAnim();
        }
    }

    public void StartAnim()
    {
        pressed = true;
        rotator.buttonPressed = true;
        if (!sliderAnim.isActiveAndEnabled)
        {
            sliderAnim.enabled = true;
        }
        else
        {
            sliderAnim.speed = 1;
        }
        if (!plateAnim.isActiveAndEnabled)
        {
            plateAnim.enabled = true;
            arrowAnim.enabled = true;
            arrowAnim2.enabled = true;
        }
        else
        {
            if (stageOne)
            {
                plateAnim.speed = 1;
                arrowAnim.speed = 1;
            }
            //else
            //{
            //    oceanAnim.speed = 1;
            //    arrowAnim.speed = 1;
            //    plateAnim.speed = 0;
            //    Debug.Log("here");
            //}
        }
    }

    public void PauseAnim()
    {
        pressed = false;
        rotator.buttonPressed = false;
        if (stageOne)
        {
            plateAnim.speed = 0;
            arrowAnim.speed = 0;
            oceanAnim.speed = 0;
            sliderAnim.speed = 0;
        }
        else
        {
            firstPerson.SetActive(true);
            rotator.enabled = false;
            cursorAnim.enabled = false;
            res.canReset = false;
            oceanAnim.speed = .5f;
            //arrowAnim.speed = .5f;
            arrowAnim.transform.gameObject.SetActive(false);
            arrowAnim2.transform.gameObject.SetActive(false);
            arrowAnim.enabled = false;
            arrowAnim2.enabled = false;
            arrowAnim3.enabled = true;
            plateAnim.speed = .5f;
            oceanAnim.enabled = true;
            //arrowAnim.SetBool("StageTwo", true);
            
        }
    }

    private void ResetAnim()
    {
        rotator.enabled = true;
        firstPerson.SetActive(false);
        simulationButtonText.text = "Add Force";
        res.canReset = true;
        animBoolScript.enoughForce = false;
        arrowAnim.SetBool("StageTwo", false);
        arrowAnim.Rebind();
        arrowAnim.Update(0f);
        arrowAnim.speed = 0;
        plateAnim.Rebind();
        plateAnim.Update(0f);
        plateAnim.speed = 0;
        oceanAnim.Rebind();
        oceanAnim.Update(0f);
        oceanAnim.speed = 0;
        stageOne = true;
        progressBar.value = 1;
    }

    IEnumerator StartCursorAnim()
    {
        yield return new WaitForSeconds(5f);
        cursorAnim.enabled = true;
    }
}
