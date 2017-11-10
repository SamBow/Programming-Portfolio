#pragma strict
var enemy1 : GameObject;
var bullet1 : GameObject;
private var starttime: boolean = false;
static var time : float;
private var startTime : float;
private var timeRemaining : float;
private var timeStr : String;


function Start () {
	enemy1 = GameObject.FindWithTag("enemy");
	bullet1 = GameObject.FindWithTag("Bullet2");
	time = 0;
}

function Update () {
	time += Time.deltaTime;
	// runs enemySpawn1
	enemySpawn1();
}

function enemySpawn1(){
// enemy set not to spawn
if (time <= 10)
{
	enemy1.gameObject.SetActive (false);
	bullet1.gameObject.SetActive (false);
}
// enemy set to spawn
if (time >= 11)
{
	enemy1.gameObject.SetActive (true);
	bullet1.gameObject.SetActive (true);
}
}