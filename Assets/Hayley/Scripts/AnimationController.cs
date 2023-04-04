using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    [Header("References")]
    public Animator plateAnim;
    public Animator oceanAnim;
    public Animator arrowAnim;

    public Button simulateButton;
    public Slider progressBar;
    public bool stageOne = true;
    public bool finished = true;
    public bool pressed = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pressed)
        {
            progressBar.value += Time.deltaTime * 10 / 18;
        }
        if (stageOne && plateAnim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        {
            stageOne = false;
            arrowAnim.SetBool("StageTwo", true);
            oceanAnim.enabled = true;
        }
        if(oceanAnim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
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
        if (!plateAnim.isActiveAndEnabled)
        {
            plateAnim.enabled = true;
            arrowAnim.enabled = true;
        }
        else
        {
            if (stageOne)
            {
                plateAnim.speed = 1;
                arrowAnim.speed = 1;
            }
            else
            {
                oceanAnim.speed = 1;
                arrowAnim.speed = 1;
            }
        }
    }

    public void PauseAnim()
    {
        pressed = false;
        if (stageOne)
        {
            plateAnim.speed = 0;
            arrowAnim.speed = 0;
            oceanAnim.speed = 0;
        }
        else
        {
            oceanAnim.speed = 0;
            arrowAnim.speed = 0;
        }
    }

    private void ResetAnim()
    {
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

        progressBar.value = 1;
    }
}
