using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererController : MonoBehaviour
{
    public Transform startPos, endPos;
    LineRenderer lr;
    Vector3[] positions;
    Camera mainCam;
    //public Transform debugger;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        positions = new Vector3[2];
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (!endPos.gameObject.GetComponent<LineEndController>().notSeen)
        {
            lr.enabled = true;
            //Debug.DrawRay(mainCam.transform.position, endPos.position - mainCam.transform.position, Color.green);
            float startDist = Vector3.Distance(mainCam.transform.position, startPos.position);
            Vector3 endDir = (endPos.position - mainCam.transform.position).normalized;
            Vector3 startScreenPos = Camera.main.WorldToScreenPoint(startPos.position);
            //Vector3 endScreenPos =  new Vector3(endPos.position.x, endPos.position.y, startPos.position.z);
            Vector3 endScreenPos = endDir * startDist;
            Debug.DrawRay(mainCam.transform.position, endScreenPos, Color.green);
            Debug.DrawRay(Vector3.zero, endScreenPos, Color.red);
            //Debug.Log(endScreenPos);
            positions[0] = startPos.position;
            positions[1] = endScreenPos + mainCam.transform.position;
            //debugger.position = endScreenPos;
            lr.SetPositions(positions);
        }
        else
        {
            lr.enabled = false;
        }
    }
}
