using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float fltDestroyDelay = 0.5f;
    bool boolHasPackage = false;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !boolHasPackage)
        {
            Debug.Log("Package picked up");
            boolHasPackage = true;
            Destroy(other.gameObject, fltDestroyDelay);
        }
        if (other.tag == "Customer" && boolHasPackage)
        {
            Debug.Log("Package delivered");
            boolHasPackage = false;
        }

    }
}
