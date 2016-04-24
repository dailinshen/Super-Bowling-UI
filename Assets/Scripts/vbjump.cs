using UnityEngine;
using System.Collections;
using Vuforia;

public class vbjump : MonoBehaviour, IVirtualButtonEventHandler{

	public GameObject Player;
	public Rigidbody player;
	public GameObject Workspace;
	private float timer =0.0f;
	private bool isTimerValid=false;
	void Start(){
		VirtualButtonBehaviour[] vbs = transform.GetComponentsInChildren<VirtualButtonBehaviour> ();
		foreach (VirtualButtonBehaviour item in vbs)
		{
			item.RegisterEventHandler(this);
		}

		Player = GameObject.Find ("Player");
		player = Player.GetComponent<Rigidbody>();
		Workspace=GameObject.Find ("EditorWorkspace");
	}

	public void Update(){
		if (isTimerValid)
		{
			player.AddRelativeForce (new Vector3 (0f, 3f, 0f));
			if (Player.transform.localPosition.y > 0.2&& Workspace.transform.localPosition.x > 0.1) {
				isTimerValid = false;
			}
		}

	}
		

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb)
	{
		if (Player.transform.localPosition.y < 0.2 && Workspace.transform.localPosition.x > 0.1) {
			isTimerValid = true;
		}
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb)
	{

		//throw new System.NotImplementedException ();
	}
}
