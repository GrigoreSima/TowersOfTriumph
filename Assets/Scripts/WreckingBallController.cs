using UnityEngine;

public class WreckingBallController : MonoBehaviour {
	public Rigidbody stopper;
	private bool destroyed;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start() {
		destroyed = false;
	}

	// Update is called once per frame
	void Update() {
		if (!destroyed && Input.GetKey(KeyCode.X)) {
			destroyed = true;
			stopper.isKinematic = false;
			return;
		}
	}
}
