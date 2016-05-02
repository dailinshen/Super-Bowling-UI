using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerCollisionControl : MonoBehaviour {
	private Rigidbody rb;
	private int count;

	public AudioClip shootSound;
	private AudioSource source;
	private float volLowRange=5.5f;
	private float volHighRange=10.0f;

	public int overalscore;

	public Text scoreText;
	// Use this for initialization
	void Awake(){
		source = GetComponent<AudioSource> ();
	}
	void Start () {
		count = 0;
		rb = GetComponent<Rigidbody> ();
		scoreText.text = "Score: " + count.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		overalscore = count;
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("BowlingPins")) {
			other.gameObject.SetActive (false);
			count += 10;

			float vol = Random.Range (volLowRange, volHighRange);
			source.PlayOneShot (shootSound, vol);

			scoreText.text = "Score: " + count.ToString ();
		}
	}
}
