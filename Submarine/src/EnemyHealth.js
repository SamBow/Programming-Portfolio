#pragma strict
var health = 5;
function Start (){}

function Update (){
	if (health <= 0)
	{
		Destroy(gameObject);
	}

}

function OnTriggerEnter(other : Collider) {
	if (other.tag == "Bullet")
	{
		health -= 10;
		Destroy(other.gameObject);
	}

}
function OnCollisionEnter (collision : Collision) {
	if (collision.gameObject.tag == "First Person Controller")
	{
		Destroy(gameObject);
	}
}
