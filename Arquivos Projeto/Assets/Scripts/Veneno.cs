﻿using UnityEngine;
using System.Collections;

public class Veneno : MonoBehaviour {
	private Transform player;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D colisor) {
		if (colisor.gameObject.tag == "Player") {
			player.position = new Vector3(0, 0, 0);
		}
	}
}