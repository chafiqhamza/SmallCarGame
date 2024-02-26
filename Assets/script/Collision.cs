using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
  
    private bool hasPackage = false;

  
    [SerializeField]  float destroyDelay = 0.5f;
    [SerializeField] Color32 hasColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 hasNocolor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "package" && !hasPackage)
        {
            Debug.Log("package");
            hasPackage = true;
            spriteRenderer.color = hasColor;
            Destroy(other.gameObject, destroyDelay);
        }

       if(other.tag == "costumer" && hasPackage) 
        {
            Debug.Log("delivred");
            hasPackage = false;
            spriteRenderer.color = hasNocolor;

        }
    }
}


