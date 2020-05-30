using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
	public Transform player;
	private Vector3 offset = new Vector3(0,1,-5);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	transform.position = player.position + offset;
    }
}
