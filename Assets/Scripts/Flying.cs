using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour {

    public float speed = 2.0f;
	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent <Transform> ().position = new Vector3 (0, 0, -5);
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.GetComponent <Transform> ().position = this.gameObject.GetComponent <Transform> ().position + speed * this.gameObject.GetComponent <Transform> ().forward;

		float hori = Input.GetAxis ("Horizontal");
		float vert = Input.GetAxis ("Vertical");
		this.gameObject.GetComponent <Transform> ().rotation = this.gameObject.GetComponent <Transform> ().rotation * Quaternion.AngleAxis (vert, new Vector3 (-1, 0, 0));
		this.gameObject.GetComponent <Transform> ().rotation = this.gameObject.GetComponent <Transform> ().rotation * Quaternion.AngleAxis (hori, new Vector3 (0, 1, 0));
	}
}
