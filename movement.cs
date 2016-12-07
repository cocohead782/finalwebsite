using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w"))
			transform.Translate(Vector3.back);
		if (Input.GetKey("a"))
			transform.Translate(Vector3.right);
		if (Input.GetKey("s"))
			transform.Translate(Vector3.forward);
		if (Input.GetKey("d"))
			transform.Translate(Vector3.left);
		if (Input.GetKey("q"))
			transform.Translate(Vector3.down);
		if (Input.GetKey("e"))
			transform.Translate(Vector3.up);
	}
}