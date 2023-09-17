using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]float fltsteerSpeed = 300f;
    [SerializeField]float fltmoveSpeed = 20f;
    [SerializeField] float fltSlowSpeed = 15f;
    [SerializeField] float fltBoostSpeed = 30f;

    

    // Update is called once per frame
    void Update()
    {
        float fltsteerAmount = UnityEngine.Input.GetAxis("Horizontal") * fltsteerSpeed * Time.deltaTime;
        float fltmoveAmount = UnityEngine.Input.GetAxis("Vertical") * fltmoveSpeed * Time.deltaTime;
        transform.Translate(0, fltmoveAmount, 0);
        transform.Rotate(0, 0, -fltsteerAmount);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            fltmoveSpeed = fltBoostSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        fltmoveSpeed = fltSlowSpeed;
    }
    
        
    
}
