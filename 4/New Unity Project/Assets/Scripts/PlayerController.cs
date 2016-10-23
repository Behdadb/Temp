using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float movementSpeed = 10.0f;
	public float rotateSpeed = 5.0f;
	public float fireRate = 0.5f;
	public UnityEngine.UI.Text ScoreText;
	public float bulletLifeTime;

	private float nextFire = 0.0f;
	private int score;
	private bool inCollision;
	private Vector3 lastPos;
	

	// Use this for initialization
	void Start () {
		score = 0;
		inCollision = false;
	}

	// Update is called once per frame
	void Update () {

		if (inCollision) {
			transform.position = lastPos;
		}

		lastPos = transform.position;

		if ( (Input.GetKey ("space") || Input.GetKey ("return") || Input.GetButton("Fire1") ) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			GameObject bullet = Instantiate (Resources.Load("Prefabs/Bullet"), Vector3.zero, Quaternion.identity) as GameObject;
			Destroy(bullet, bulletLifeTime);
		}

		if (Input.GetKey ("right")) { // rotate to right

			Quaternion rotation = transform.rotation;
			rotation.eulerAngles += new Vector3 (0f, rotateSpeed, 0f);
			transform.rotation = rotation;

		}
		if (Input.GetKey ("left")) { // rotate to left

			Quaternion rotation = transform.rotation;
			rotation.eulerAngles += new Vector3 (0f, -rotateSpeed ,0f);
			transform.rotation = rotation;

		}
		if (Input.GetKey ("up")) { // rotate up to the limit of 70 degrees (if 90 is facing sky directly)
			
			Quaternion rotation = transform.rotation;
			if( (360 + rotation.eulerAngles.x)%360 >= 290 || rotation.eulerAngles.x <= 90){
				rotation.eulerAngles += new Vector3 ( -rotateSpeed , 0f ,0f);
				transform.rotation = rotation;
			}
			
		}

		if (Input.GetKey ("down")){ // rotate down to the limit of -70 degrees (if -90 is facing ground directly)
			
			Quaternion rotation = transform.rotation;
			if( (360 + rotation.eulerAngles.x)%360 <= 80 || rotation.eulerAngles.x >= 270){
				rotation.eulerAngles += new Vector3 ( rotateSpeed , 0f ,0f);
				transform.rotation = rotation;
			}
			
		}
		if (Input.GetKey ("d")) { // Going right in relative to the direction player is faced

			transform.position += Vector3.back * Mathf.Sin((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;
			transform.position += Vector3.right * Mathf.Cos((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;
		
		}
		if (Input.GetKey ("a")) { // Going left in relative to the direction player is faced

			transform.position += Vector3.forward * Mathf.Sin((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;
			transform.position += Vector3.left * Mathf.Cos((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;

		}
		if (Input.GetKey ("w")) {	// Going forward in relative to the direction player is faced

			transform.position += Vector3.forward * Mathf.Cos((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;
			transform.position += Vector3.right * Mathf.Sin((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;

		}

		if (Input.GetKey ("s")) {	// Going back in relative to the direction player is faced

			transform.position += Vector3.back * Mathf.Cos((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;
			transform.position += Vector3.left * Mathf.Sin((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;

		}
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Wall") {
			inCollision = true;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Wall") {
			inCollision = false;
		}
	}

	public void IncreasScore(){

		score++;
		ScoreText.text = "Score : " + score;
	}

}
