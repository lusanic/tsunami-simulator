using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineEndController : MonoBehaviour
{
    public bool notSeen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnBecameVisible()
    {
        notSeen = false;
    }
    private void OnBecameInvisible()
    {
        notSeen = true;
    }
}
