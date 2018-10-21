using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour {
    private Rigidbody rb;
    private int count;
    public float speed;
    public Text countText;
    public Text winText;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

        count = 0;

        SelectText();

        winText.text = "";

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
            count += 1;
            SelectText();
        }
    }

    void SelectText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 8){
            winText.text = "You win";
        }
    }
}
