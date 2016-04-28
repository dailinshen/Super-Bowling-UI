using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pathmove : MonoBehaviour {
	public GameObject pathImageTarget;
	public GameObject Cam;
	public GameObject Workspace;
	public GameObject Player;
	public Rigidbody player;
	private float speed;
	private float lastCamy;
	private float lastCamx;
	private bool  playflag;
	public Text test;

	// Use this for initialization
	void Start () {
		//HcourseV1 = GameObject.Find ("HcourseV1");
		Cam= GameObject.Find("ARCamera");
		pathImageTarget = GameObject.Find ("PathImageTarget");
		Workspace=GameObject.Find ("EditorWorkspace");
		Player = GameObject.Find ("Player");
		player = Player.GetComponent<Rigidbody>();
		speed = 1.0f;
		lastCamy = Cam.transform.rotation.y;
		lastCamx = Cam.transform.rotation.x;
		playflag = true;
		Debug.Log (Player.transform.localPosition.y);
	}




	// Update is called once per frame
	void Update () {
		Debug.Log (Cam.transform.position.x);
		// Debug.Log (pathImageTarget.transform.position);
		test.text = "";
		if (Cam.transform.position.x > -13.6 && Cam.transform.position.x < -13.2) {
			test.text = "got here and playflag is:"+ playflag.ToString();
		}
		test.text =test.text+ "             Cam rotation x:"+Cam.transform.rotation.x.ToString()+
			"       Cam rotation y:"+Cam.transform.rotation.y.ToString()+
			"       Cam rotation z:"+Cam.transform.rotation.z.ToString()+
			"       Cam rotation w:"+Cam.transform.rotation.w.ToString();
		test.text = test.text + "           Cam Position x:" + Cam.transform.position.x.ToString () +
			"      Cam Position y:" + Cam.transform.position.y.ToString () +
			"      Cam Position z:" + Cam.transform.position.z.ToString ();
		test.text = test.text + "           player Position x:" + Player.transform.localPosition.x.ToString () +
			"     player Position y:" + Player.transform.localPosition.y.ToString () +
			"      player Position z:" + Player.transform.localPosition.z.ToString ();
		if (!playflag) {
			EasyModeControl link = Cam.GetComponent<EasyModeControl> ();
			link.Exit();
		}

		if (Cam.transform.position.x>-13.6 &&Cam.transform.position.x<-13.2) {
			if (transform.localPosition.x > 0.1) {
				player.AddRelativeForce (new Vector3 (0f, -1f, 0f));
			}
			test.text =test.text+ "got here";
			speed =Mathf.Max((1+(Cam.transform.rotation.x + 0.35f) * 15f),0);
			Vector3 move1 = transform.localPosition + new Vector3(0.1f,0f,0f) *(speed)*Time.deltaTime ;
			transform.localPosition = move1;
			Vector3 move2 = Player.transform.localPosition + new Vector3 (0f, 0f, -0.05f) * Cam.transform.rotation.y*2;
			Player.transform.localPosition = move2;
			lastCamx = Cam.transform.rotation.x;
			lastCamy = Cam.transform.rotation.y;

			if (Player.transform.localPosition.y < -1 ||transform.localPosition.x>14.2) {
				playflag = false;
			}

		}
	}
}
