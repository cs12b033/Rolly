using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;

    private float sidewaysForce = 1000000;
    private float forwardFoce = 800000;

    void Awake()
    {
		sidewaysForce *= Time.deltaTime;
    	forwardFoce *= Time.deltaTime;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, forwardFoce);   
    }

    // Update is called once per frame
    void Update()
    {

    }


    void FixedUpdate()
    {
        // if (transform.postion.y < 1) 
        // {
        //     Application.Quit();
        // }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce, 0, forwardFoce);
        }
        else if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce, 0, forwardFoce);
        }
        else {
            rb.AddForce(0, 0, forwardFoce);
        }
    }

    void Stop()
    {
        Debug.Log("Stopped");
    }
}
