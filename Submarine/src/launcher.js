
static var speed = 100;

var projectile: Rigidbody;


static var magicone = true;

function Update () {
	
	
	
	if(Input.GetButtonDown("Fire1"))
	{
		var instantiatedProjectile: Rigidbody = Instantiate(projectile, transform.position, transform.rotation);
		instantiatedProjectile.velocity = transform.TransformDirection(Vector3(0,0,speed));
		Physics.IgnoreCollision(instantiatedProjectile.collider, transform.root.collider);
	
	}
			
}
