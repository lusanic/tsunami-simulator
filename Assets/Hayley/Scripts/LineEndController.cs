using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineEndController : MonoBehaviour
{
    public bool notSeen;

    Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (r.isVisible)
        //    notSeen = false;
        //else
        //    notSeen = true;
        //if (transform.position.z < 2.7f)
        //    notSeen = true;
        //else
        //    notSeen = false;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Camera.main.transform.position - transform.position, Vector3.Distance(transform.position, Camera.main.transform.position)))
        {
            notSeen = true;
        }
        else
        {
            notSeen = false;
        }
    }

    private void OnDisable()
    {
        notSeen = true;
    }

    //private void OnBecameVisible()
    //{
    //    notSeen = false;
    //}
    //private void OnBecameInvisible()
    //{
    //    notSeen = true;
    //    Debug.Log("not seen");
    //}
}
