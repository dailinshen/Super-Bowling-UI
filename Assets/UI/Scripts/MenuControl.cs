using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MenuControl : MonoBehaviour {

	public Canvas MainMenu;
	public Canvas LevelMenu;
	public Canvas TopScoresMenu;

	public Text TopScoreList;

	// Use this for initialization
	void Start () {
		MainMenu = MainMenu.GetComponent<Canvas> ();
		LevelMenu = LevelMenu.GetComponent<Canvas> ();
		TopScoresMenu = TopScoresMenu.GetComponent<Canvas> ();
		TopScoresMenu.enabled = false;
		LevelMenu.enabled = false;
		MainMenu.enabled = true;

	}

	public void LevelMode(){
		LevelMenu.enabled = true;
		int xxx = GameObject.Find ("Player").GetComponent<PlayerCollisionControl> ().overalscore;
		TopScoreList.text = "Score: " + xxx.ToString();
	}
	public void TopScoresMode(){
		TopScoresMenu.enabled = true;
	}
	public void ReturnMode(){
		LevelMenu.enabled = false;
		TopScoresMenu.enabled = false;
	}
	public void PlayMode(){
		Application.LoadLevel (1);
	}
	public void EasyMode(){
		Application.LoadLevel (2);
	}
	public void HardMode(){
		Application.LoadLevel (3);
	}
	public void BuildMode(){
		Application.LoadLevel (1);
	}

	public void ExitGame(){
		Application.Quit ();
	}

	// Update is called once per frame
	void Update () {

	}
}
