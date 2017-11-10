
var enemy : GameObject;                
var spawnTime : float = 3f;            
var spawnPoints : Transform[];         


function Start ()
{
    InvokeRepeating ("Spawn", spawnTime, spawnTime);
}


function Spawn ()
{
    var spawnPointIndex : int = Random.Range (0, spawnPoints.Length);
    Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
}
