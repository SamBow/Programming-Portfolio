
	var startMarker: Transform;
	var endMarker: Transform;
	
	var speed = 10.0;
	
	private var startTime: float;

	private var journeyLength: float;
	
	var Player : Transform;
	var smooth = 5.0;
	
	function Start() {
		startTime = Time.time;
		
		journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
	}
	
	function Update () {
		var distCovered = (Time.time - startTime) * speed;
		
		var fracJourney = distCovered / journeyLength;

		transform.position=Vector3.Lerp(startMarker.position, endMarker.position, Mathf.PingPong(Time.time*speed, 1.0f));
	}
