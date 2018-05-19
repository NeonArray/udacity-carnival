using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {
	
	void Update () {
		transform.GetComponent<Rigidbody>().AddForce(Vector3.up * (Time.deltaTime / 14000));
	}
}
