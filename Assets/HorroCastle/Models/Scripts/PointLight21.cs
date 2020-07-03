using UnityEngine;
using System.Collections;

public class PointLight21 : MonoBehaviour {

	public GameObject toActivate;
	public GameObject character;
	Animator anim;
	bool triggerIn = false;
	float rotY;

	void OnTriggerEnter(Collider col) {
		
		anim.enabled = true;
		triggerIn = true;


	}
	
	void Start(){
		
		anim = toActivate.GetComponent<Animator>();
		anim.enabled = false;

		rotY = character.transform.rotation.y;

	}

	void Update(){

		if (triggerIn == true) {

			rotY = Mathf.Lerp(rotY , 185 , 2 * Time.deltaTime );

			character.transform.rotation = Quaternion.Euler(character.transform.rotation.x, rotY, character.transform.rotation.z);
		}


	}
}
