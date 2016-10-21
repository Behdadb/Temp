using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public float bulletSpeed;

	private GameObject gun;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		gun = GameObject.Find("Gun");
		transform.position = gun.transform.position;
		transform.rotation = gun.transform.rotation;
		rb = GetComponent<Rigidbody>();
		rb.velocity = transform.forward * bulletSpeed;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
