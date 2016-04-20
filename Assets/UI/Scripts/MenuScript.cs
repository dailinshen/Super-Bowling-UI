// Attach to the main camera
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
	public Canvas mainMenu;
	public Canvas quitMenu;
	public Button StartText;
	public Button exitText;

	public Texture BackgroundTexture;

	void OnGUI(){
		//Display our Background Texture
		GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height), BackgroundTexture);
	}
	// Use this for initialization
	void Start () {
		mainMenu = mainMenu.GetComponent<Canvas> ();
		quitMenu = quitMenu.GetComponent<Canvas> ();
		StartText = StartText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
		mainMenu.enabled = true;
	}

	public void ExitPress(){
		mainMenu.enabled = false;
		quitMenu.enabled = true;
		StartText.enabled = false;
		exitText.enabled = false;
	}

	public void NoPress(){
		mainMenu.enabled = true;
		quitMenu.enabled = false;
		StartText.enabled = true;
		exitText.enabled = true;
	}

	public void StartLevel(){
		Application.LoadLevel (1);
	}

	public void ExitGame(){
		Application.Quit ();
	}

	// Update is called once per frame
	void Update () {
	
	}
}
