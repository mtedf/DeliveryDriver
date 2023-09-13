using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 clrHasPackage = new Color32 (1,1,1,1);
    [SerializeField] Color32 clrNoPackage = new Color32(1, 1, 1, 1);

    [SerializeField] float fltDestroyDelay = 0.5f;
    bool boolHasPackage = false;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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
            spriteRenderer.color = clrHasPackage;
            Destroy(other.gameObject, fltDestroyDelay);
        }
        if (other.tag == "Customer" && boolHasPackage)
        {
            Debug.Log("Package delivered");
            boolHasPackage = false;
            spriteRenderer.color = clrNoPackage;
        }

    }
}
