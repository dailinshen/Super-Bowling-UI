using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EasyModeControl : MonoBehaviour {
	public Canvas ExitWindow;
	public bool exitpressed;
	private GUIStyle guistyle=new GUIStyle();
	private Text counterText;
	private float seconds, minutes;

	public void Exit(){
		ExitWindow.enabled = true;
		exitpressed = true;
	}
	public void Restart(){
		Application.LoadLevel (Application.loadedLevel);
	}
	public void ExitAnyWay(){
		Application.LoadLevel(1);
	}
	public void Resume(){
		ExitWindow.enabled = false;
		exitpressed = false;
	}
	// Use this for initialization
	void Start () {
		ExitWindow = ExitWindow.GetComponent<Canvas> ();
		ExitWindow.enabled = false;
		exitpressed = false;
		counterText = GetComponent<Text> () as Text;
	}
	void OnGUI(){
		minutes = (int)(Time.timeSinceLevelLoad / 60f);
		seconds = (int)(Time.timeSinceLevelLoad % 60f);
		guistyle.fontSize = 30;
		guistyle.normal.textColor = Color.green;
		//guistyle.fontStyle=
		GUI.Label (new Rect (50, 20, 400, 50), minutes.ToString ("00") + ":" + seconds.ToString ("00"),guistyle);
	}
	// Update is called once per frame
	void Update () {
		if (exitpressed)
			Time.timeScale = 0;
		else
			Time.timeScale= 1;
	}
}
