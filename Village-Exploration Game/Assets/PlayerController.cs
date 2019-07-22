using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public float walkingSpeed;
    public float rotationSpeed;

    public LayerMask mask;

    float horMov, verMov;
    CharacterController charContr;
	// Use this for initialization
	void Start () {
        charContr = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        GetAlignment();
        Movement();
	}

    private void GetAlignment()
    {
        RaycastHit hit; Physics.Raycast(transform.position, -transform.up, out hit, 0.7f, mask);

        Vector3 newUp = hit.normal;
        transform.up = newUp; 
    }

    private void Movement()
    {

        horMov = Input.GetAxisRaw("Horizontal") * rotationSpeed;
        verMov = Input.GetAxisRaw("Vertical") * walkingSpeed;

        Vector3 newPosition = new Vector3(0, 0, verMov);
        newPosition = transform.TransformDirection(newPosition);    // Makes rotation thing work.

        charContr.Move(newPosition);
        transform.Rotate(new Vector3(0, horMov, 0));

        Debug.Log(horMov);

    }
}
