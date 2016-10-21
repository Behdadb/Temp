using UnityEngine;
using System.Collections;

public class TargetController : MonoBehaviour {

	public float markLifeTime;

	void OnCollisionEnter(Collision collision) {

		if (collision.gameObject.tag == "Bullet") {
			
			GameObject player = GameObject.Find("Player");
			PlayerController pc = player.GetComponent<PlayerController>();
			pc.IncreasScore();

			GameObject mark = Instantiate (Resources.Load("Prefabs/BulletMark"), collision.contacts[0].point, transform.rotation) as GameObject;
			Destroy(mark, markLifeTime);
		}
		
	}
}
