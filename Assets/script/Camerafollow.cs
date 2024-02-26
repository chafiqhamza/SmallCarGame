using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    [SerializeField] GameObject follow;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        transform.position = follow.transform.position + new Vector3(0,0,-10);
    }
}
