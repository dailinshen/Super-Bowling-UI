using UnityEngine;
using System.Collections;

public class Pathmove : MonoBehaviour {
	//public GameObject HcourseV1;
	public GameObject pathImageTarget;
	private 
	// Use this for initialization
	void Start () {
		//HcourseV1 = GameObject.Find ("HcourseV1");
		pathImageTarget = GameObject.Find ("PathImageTarget");

	}

	// Update is called once per frame
	void Update () {
		Debug.Log (pathImageTarget.transform.position);
		if (pathImageTarget.transform.position.y>-3 &&pathImageTarget.transform.position.y<3 ) {
			Vector3 temp = transform.localPosition + new Vector3 (0.2f, 0.0f, 0.0f) * Time.deltaTime * 5;
			//HcourseV1.transform.loc
			transform.localPosition = temp;
		}
	}
}
