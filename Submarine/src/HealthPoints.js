#pragma strict

function OnTriggerEnter(other : Collider){
	if (other.tag == "ground")
	{
		Destroy(gameObject);
	}
}
