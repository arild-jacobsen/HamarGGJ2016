using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float walkingSpeed = 5f;
	//public AudioSource clickSound;

	Vector3 targetPosition;
	Animator derAnimator;

	// Use this for initialization
	void Start () {
		targetPosition = transform.position;
		derAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			//clickSound.Play();
			Vector3 target = Input.mousePosition;
			target.z = -Camera.main.gameObject.transform.position.z;
			targetPosition = Camera.main.ScreenToWorldPoint(target);
			targetPosition.y = transform.position.y;
		}
		bool shouldMove = !targetPosition.Equals (transform.position);
		derAnimator.SetBool ("playerIsMoving", shouldMove);
		if (shouldMove) {
			Vector3 movement = targetPosition - transform.position;
			Vector3 theScale = transform.localScale;
			theScale.x = Mathf.Abs(theScale.x) * Mathf.Sign(movement.x);
			transform.localScale = theScale;
			transform.position = Vector3.MoveTowards(transform.position, targetPosition, walkingSpeed * Time.deltaTime);
		}
	}
}
