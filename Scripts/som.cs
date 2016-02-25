using UnityEngine;
using System.Collections;

public class som : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		GetComponent<AudioSource>().Play();
	}
}