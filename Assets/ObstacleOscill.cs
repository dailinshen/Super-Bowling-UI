using UnityEngine;
using System.Collections;

public class ObstacleOscill : MonoBehaviour {
	public float min=-1f;
	public float max=1f;
	// Use this for initialization
	void Start () {
		min=transform.position.x-1;
		max=transform.position.x+1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position =new Vector3(Mathf.PingPong(Time.time,max-min)+min, transform.position.y, transform.position.z);
	}
}
