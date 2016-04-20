using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MenuControl : MonoBehaviour {

	public Canvas MainMenu;
	public Canvas LevelMenu;
	// Use this for initialization
	void Start () {
		MainMenu = MainMenu.GetComponent<Canvas> ();
		LevelMenu = LevelMenu.GetComponent<Canvas> ();
		LevelMenu.enabled = false;
		MainMenu.enabled = true;
	}

	public void LevelMode(){
		LevelMenu.enabled = true;
	}
	public void ReturnMode(){
		LevelMenu.enabled = false;
	}
	public void PlayMode(){
		Application.LoadLevel (0);
	}
	public void EasyMode(){
		Application.LoadLevel (0);
	}
	public void HardMode(){
		Application.LoadLevel (0);
	}
	public void BuildMode(){
		Application.LoadLevel (0);
	}
	/*public void ExitPress(){
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

	public void ExitGame(){
		Application.Quit ();
	}
*/
	// Update is called once per frame
	void Update () {

	}
}
