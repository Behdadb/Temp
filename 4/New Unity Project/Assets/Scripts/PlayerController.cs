using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float movementSpeed = 10.0f;
	public float rotateSpeed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("right")) {

			transform.Rotate (new Vector3 (0f, rotateSpeed, 0f));

		}
		if (Input.GetKey ("d")) {
			
			transform.position += Vector3.back * Mathf.Sin((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;
			transform.position += Vector3.right * Mathf.Cos((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;
			
		}
		if (Input.GetKey ("left")) {

			transform.Rotate(new Vector3 (0f, -rotateSpeed ,0f) );

		}
		if (Input.GetKey ("a")) {
			
			transform.position += Vector3.forward * Mathf.Sin((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;
			transform.position += Vector3.left * Mathf.Cos((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;
			
		}
		if (Input.GetKey ("up") || Input.GetKey ("w")) {

			transform.position += Vector3.forward * Mathf.Cos((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;
			transform.position += Vector3.right * Mathf.Sin((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;

		}
		if (Input.GetKey ("down") || Input.GetKey ("s")) {

			transform.position += Vector3.back * Mathf.Cos((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;
			transform.position += Vector3.left * Mathf.Sin((transform.eulerAngles.y * Mathf.PI ) / 180f) * Time.deltaTime * movementSpeed;
		}
	}

}
