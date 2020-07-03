using UnityEngine;
using System.Collections;

public class LightActivator : MonoBehaviour {

	public GameObject toActivate;

	void OnTriggerEnter(Collider col) {

		toActivate.SetActive(true);

	}

	void Start(){

		toActivate.SetActive(false);
	}
}
