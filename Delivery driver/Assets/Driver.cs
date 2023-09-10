using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]float fltsteerSpeed = 300f;
    [SerializeField]float fltmoveSpeed = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float fltsteerAmount = UnityEngine.Input.GetAxis("Horizontal") * fltsteerSpeed * Time.deltaTime;
        float fltmoveAmount = UnityEngine.Input.GetAxis("Vertical") * fltmoveSpeed * Time.deltaTime;
        transform.Translate(0, fltmoveAmount, 0);
        transform.Rotate(0, 0, -fltsteerAmount);
    }
}
