using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragRotate : MonoBehaviour
{
    public bool buttonPressed;
    public Animator cursorAnim;
    Vector3 mPrevPos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && !buttonPressed)
        {

            cursorAnim.gameObject.SetActive(false);
            cursorAnim.enabled = false;

            mPosDelta = Input.mousePosition - mPrevPos;
            //if(Vector3.Dot(transform.up, Vector3.up) >= 0)
            //{
            //    transform.Rotate(transform.up, -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
            //}
            //else
            //{
            //    transform.Rotate(transform.up, Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
            //}

            //transform.Rotate(Camera.main.transform.right, Vector3.Dot(mPosDelta, Camera.main.transform.up), Space.World);

            transform.Rotate(transform.up, Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
        }

        mPrevPos = Input.mousePosition;
    } 
}
