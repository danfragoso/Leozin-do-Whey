using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	
	public int value = 10;
	

	void Start () {
		
	}
	

	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D colisor) {
		if (colisor.gameObject.tag.Equals ("Player")) {
			var scriptPlayer = colisor.gameObject.GetComponent<Player>(); //Recupera o script
			scriptPlayer.addCoins(value); //Adiciona o valor
			Destroy(gameObject); //Destroi a moeda
		}
	}
}
