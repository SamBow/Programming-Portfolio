#pragma strict
static var health = 100;
static var healthText = "Health: 10";
var reset : Texture2D;
var health1 : Texture2D;
var health2 : Texture2D;
var health3 : Texture2D;
var health4 : Texture2D;
var health5 : Texture2D;
var MineHit : AudioClip;
var HealthHit : AudioClip;
var Background : AudioClip;


function Start () {
	health = 100;
	audio.PlayOneShot(Background);
}
function Update () {
}

function OnGUI () {
// health and reset buttons

	// reloads current level
	if(GUI.Button(Rect(10,10,75,75), reset, GUIStyle.none ))
	{
		Application.LoadLevel(Application.loadedLevel);
	}
	// displays health
	if (health < 100)
	{
		GUI.Button(Rect(10,75,250,75), health1, GUIStyle.none);
	}
	if (health <= 100)
	{	
	GUI.Button(Rect(10,75,250,75), health1, GUIStyle.none);
    }
	if (health <= 81)
	{
	GUI.Button(Rect(10,75,250,75), health2, GUIStyle.none);
	}
	if (health <= 61)
	{
		GUI.Button(Rect(10,75,250,75), health3, GUIStyle.none);
	}
	if (health <= 41)
	{
		GUI.Button(Rect(10,75,250,75), health4, GUIStyle.none);
	}
	if (health <= 21)
	{
		GUI.Button(Rect(10,75,250,75), health5, GUIStyle.none);
	}
	
	// health % on health.GUI
	GUI.Label(Rect(123,95,50,50), healthText);
	healthText="" + health;
}	

function OnTriggerEnter (other : Collider) {
	//gain health
	if (other.tag == "health")
	{
		health += 5;

		audio.PlayOneShot(HealthHit);

		Destroy(other.gameObject);
	}
	//lose health
	if (other.tag == "mine")
	{
		audio.PlayOneShot(MineHit);
		health -= 50;
	}	
	if (other.tag == "enemy")
	{
		health -= 100;
	}
	//reloads level when health == 0
	if (health <= 0) 
	{
		Application.LoadLevel(Application.loadedLevel);
	}
	// enenmy damage
	if (other.tag == "Bullet2")
	{
		health -= 20;
		Destroy(other.gameObject);
	}
	if (other.tag == "bullettwo")
	{
		health -= 20;
		Destroy(other.gameObject);
	}
	if (other.tag == "bullet3")
	{
		health -= 20;
		Destroy(other.gameObject);
	}
}

function OnCollisionEnter (collision : Collision) {
	var contact: ContactPoint = collision.contacts[0];
	var rotation = Quaternion.FromToRotation(Vector3.up,contact.normal);
	if (collision.gameObject.tag == "enemy")
	{
		health -= 4;
		Debug.Log("Test");
	}
}
