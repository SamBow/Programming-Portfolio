#pragma strict
var health = 10;

function Start () {
}

function Update () {
if (health <= 0)
	{
		Destroy(gameObject);
	}
}
function OnTriggerEnter (other : Collider) {
	if (other.tag == "ground")
	{
		Destroy(gameObject);
	}
}