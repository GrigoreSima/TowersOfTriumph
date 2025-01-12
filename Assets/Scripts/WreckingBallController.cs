using UnityEngine;

public class WreckingBallController : MonoBehaviour {
	public HingeJoint _hingeToDestroy;
	public Rigidbody stopper;
	private bool destroyed;
	private bool detached;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start() {
		destroyed = false;
		detached = false;
	}

	// Update is called once per frame
	void Update() {
		if (!destroyed && Input.GetKey(KeyCode.Space)) {
			destroyed = true;
			stopper.isKinematic = false;
			stopper = null;
			return;
		}
		if(destroyed && !detached && Input.GetKey(KeyCode.X)) {
			Destroy(_hingeToDestroy);
			detached = true;
			return;
		}
	}
}
