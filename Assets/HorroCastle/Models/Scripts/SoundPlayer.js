#pragma strict

var Audio : AudioSource;
//var other : Collider;


function Start () {

}

function OnTriggerEnter(Collider){

	Debug.Log("Great");
	Audio.Play();
	

}


function Update () {

}