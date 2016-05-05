using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerCollisionControl : MonoBehaviour {
	private Rigidbody rb;
	private int count;
	private int level;
	private string levelname;
	public AudioClip shootSound;
	private AudioSource source;
	private float volLowRange=5.5f;
	private float volHighRange=10.0f;

	//	public static int overalscore;
	public static int overalscore_easy;
	public static int overalscore_hard;
	public static int overalscore_build;

	public Text scoreText;
	// Use this for initialization
	void Awake(){
		source = GetComponent<AudioSource> ();
	}

    public void SetCount(int c)
    {
        count = c;
    }
	void Start () {
		//overalscore = 0;
		count = 0;
		rb = GetComponent<Rigidbody> ();
		level = SceneManager.GetActiveScene ().buildIndex;
		switch (level) {
		case 1:
			levelname = "BuildMode";
			break;
		case 2:
			levelname = "Easy";
			break;
		case 3:
			levelname = "Hard";
			break;
		}
		scoreText.text = "Score: " + count.ToString ()+"; Level: "+levelname;
	}

	// Update is called once per frame
	void Update () {
		//overalscore = count;
		if (!GameObject.Find ("EditorWorkspace").GetComponent<Pathmove> ().playflag) {
			switch (level) {
			case 1:
				if (overalscore_build < count)
					overalscore_build = count;
				break;
			case 2:
				if (overalscore_easy < count)
					overalscore_easy = count;
				break;
			case 3:
				if (overalscore_hard < count)
					overalscore_hard = count;
				break;
			}
			//			if (overalscore < count)
			//				overalscore = count;
		}
		//Debug.Log (count);
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("BowlingPins")) {
			other.gameObject.SetActive (false);
			count += 10;

			float vol = Random.Range (volLowRange, volHighRange);
			source.PlayOneShot (shootSound, vol);

			scoreText.text = "Score: " + count.ToString ()+"; Level: "+levelname;
			//scoreText.text = "Score: " + overalscore.ToString ();
		}
	}

}
