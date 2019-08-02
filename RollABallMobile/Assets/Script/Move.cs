using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [Range(10,40)]
    public float velocidade = 10f ;

    private Vector3 moviA;
    private Vector3 movi;
    private float x;
    private float y;
    private Rigidbody rb;
    private float z;


    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movi = Vector3.zero;
    }

    
    void FixedUpdate()
    {


        // y = Input.GetAxis("Vertical"); 
        //x = Input.GetAxis("Horizontal");

        moviA = Input.acceleration;

        movi.x = moviA.x;
        movi.z = moviA.y;
         
        rb.AddForce(movi* velocidade);
       

    }
}
