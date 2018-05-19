using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlinkoWin : MonoBehaviour
{

	[Tooltip("A sound to celebrate")]
	public AudioSource Yay;

	[Tooltip("A particle effect to burst and celebrate")]
	public ParticleSystem ps;

	public GameObject balloon;

	void OnTriggerEnter (Collider other) {
		if (other.GetComponent<PlinkoCoin>() != null) {
			Yay.Play();
			ps.Emit(50);
			Instantiate(balloon, transform.position + transform.forward.normalized * .5f,
			Quaternion.LookRotation(-transform.forward));
		}
	}
}
