using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

	private int i;
	private Animator anim;

	// Use this for initialization
	void Start () {
		i = Random.Range (-15, 15);
		anim = GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Rotate ();
		SelfDestroy ();
	}

	void Rotate(){
		
		this.gameObject.transform.eulerAngles = new Vector3 (0f, 0f, transform.eulerAngles.y -i);
		if (i > 0) {
			i+=5;
		} else {
			i-=5;
		}
	}

	void SelfDestroy(){
		if (transform.position.y < -10) {
			Debug.Log ("Tira uma vida do cara");
			Destroy (gameObject);

		}
	}

	void OnMouseDown(){
		if (transform.tag == "Ball") {
			anim.SetBool ("Shoot", true);
			Debug.Log ("GG");
			Destroy (gameObject, 0.5f);
			//contar pontos
		} else if (transform.tag == "Bomb") {
			anim.SetBool ("Shoot", true);
			Debug.Log ("Game over");
			Destroy (gameObject, 0.5f);
		}  
	}


}
