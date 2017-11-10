#pragma strict
var createenemy = false;
private var starttime: boolean = false;
private var time : float;
private var startTime : float;
private var timeRemaining : float;
private var timeStr : String;
var enemy : GameObject;

function Update () {
    
    time += Time.deltaTime;

	if(time >= 10)
	{
	createenemy = true;
	}
	 var minutes : int;
    minutes = time;
    timeStr = minutes.ToString();
    Debug.Log(time);
}
