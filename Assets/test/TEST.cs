using UnityEngine;
using System.Collections;

public class TEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.right * 20 *Time.deltaTime);
	}
}
