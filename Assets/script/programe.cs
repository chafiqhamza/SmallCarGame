using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class programe : MonoBehaviour
{

    [SerializeField] float steerSpeed = 150;
    [SerializeField]float MoveSpeed = 10;
    [SerializeField] float SlowSpeed = 10;
    [SerializeField] float SpeedBoost = 25;
    // Start is called before the first frame update
    void Start()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "boost") 
        {
            Debug.Log("boost");
            MoveSpeed = SpeedBoost  ;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MoveSpeed = SlowSpeed ;
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmaount = Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;
        float MoveSpeedAmount = Input.GetAxis("Vertical")*MoveSpeed* Time.deltaTime;
        transform.Translate(0,MoveSpeedAmount,0);
        transform.Rotate(0, 0,-steerAmaount);
    }
}
