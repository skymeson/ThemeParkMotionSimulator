#pragma strict

var AudioFile : AudioSource;
var Timer : int;

function Start () {
	AudioFile.Stop();
}

function Update () {
	if(Time.time <= Timer){
	
		AudioFile.Play();
	
	}
}