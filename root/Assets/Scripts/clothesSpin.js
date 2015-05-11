#pragma strict

var spinx : int = 0;
var spiny : int = 0;
var spinz : int = 0;

function Start () {

}

function Update () {
	transform.Rotate(spinx, spiny, spinz);
}