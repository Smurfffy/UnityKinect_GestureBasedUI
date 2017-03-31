#pragma strict

var timer : float = 10.0;

function Update() {
	timer -= Time.deltaTime;

	if (timer <= 0){
		timer = 0;
		Application.LoadLevel ("mazeGame");
	}
}

function OnGUI()
{
	GUI.Box(new Rect(10, 10, 50, 20), "" + timer.ToString("0"));
}
