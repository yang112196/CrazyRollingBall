using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float Hori = Input.GetAxis("Horizontal");

        float Vert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(Hori, 0.0f, Vert);

        rb.AddForce(movement*speed);
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
