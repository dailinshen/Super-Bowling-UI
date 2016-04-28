using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerCollisionControl : MonoBehaviour {
	private Rigidbody rb;
	private int count;

	public Text scoreText;
	// Use this for initialization
	void Start () {
		count = 0;
		rb = GetComponent<Rigidbody> ();
		scoreText.text = "Score: " + count.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("BowlingPins")) {
			other.gameObject.SetActive (false);
			count += 10;
			scoreText.text = "Score: " + count.ToString ();
		}
	}
}
