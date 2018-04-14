using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;
    private float maxSpeed=5f;
    private Vector3 initial;
    private Vector3 input;
    

    // Use this for initialization
    void Start () {

        initial = transform.position;
		
	}

    // Update is called once per frame
    void Update() {
        input = new Vector3(CrossPlatformInputManager.GetAxisRaw("Horizontal"), 0, CrossPlatformInputManager.GetAxisRaw("Vertical"));
        //input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed) {

            GetComponent<Rigidbody>().AddForce(input * moveSpeed);
        }

        if (transform.position.y < 0)
        {
            Death();
        }
    }
        
    void OnCollisionEnter(Collision other)
        {

            if (other.transform.tag == "Enemy")
        {
            Death();
        }
            if (other.transform.tag == "Goal")
        {
            Manager.CompleteLevel();

        }
        }
    void OnTriggerEnter(Collision other)

    {
        
        if (other.transform.tag == "Goal")
        {

            Manager.CompleteLevel();
            print("I win the game");

        }

    }
	void Death()
    {

        transform.position = initial;

    }
	}

