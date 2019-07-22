using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {

    public GameObject followTarget;
    private Vector3 offset;

	// Use this for initialization
	void Start () {

        offset = this.transform.position - followTarget.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position = followTarget.transform.position + offset;

    }
}
