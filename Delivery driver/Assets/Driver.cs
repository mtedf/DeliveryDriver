using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]float fltsteerSpeed = 1f;
    [SerializeField]float fltmoveSpeed = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, fltmoveSpeed, 0);
        transform.Rotate(0, 0, fltsteerSpeed);
    }
}
