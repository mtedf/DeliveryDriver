using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool boolHasPackage = false;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("Package picked up");
            boolHasPackage = true;
        }
        if (other.tag == "Customer" && boolHasPackage)
        {
            Debug.Log("Package delivered");
            boolHasPackage = false;
        }

    }
}
