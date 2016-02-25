using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour {
	private static int coins;
	public float velocidade;
	public float forcaPulo;
	public bool estaNoChao;
	public Transform chaoVerificador;
	public Transform spritePlayer;
	private Animator animator;

	void Start () {
		animator = spritePlayer.GetComponent<Animator> ();
		
	}
	

	void Update () {
		Movimentacao();

	}
	
	void Movimentacao() {
		estaNoChao = Physics2D.Linecast(transform.position, chaoVerificador.position, 1 << LayerMask.NameToLayer("Piso"));
		if (Input.GetAxisRaw("Horizontal") > 0 ) {
			transform.Translate ( Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);
		}
		
		if (Input.GetAxisRaw("Horizontal") < 0 ) {
			transform.Translate (Vector2.right  * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 180);
		}
		
		if (Input.GetButtonDown("Jump") && estaNoChao) {
			GetComponent<Rigidbody2D>().AddForce(transform.up * forcaPulo);
		}
		animator.SetFloat("movimento", Mathf.Abs (Input.GetAxisRaw ("Horizontal")));					
		estaNoChao = Physics2D.Linecast(transform.position, chaoVerificador.position, 1 << LayerMask.NameToLayer("Piso"));
		animator.SetBool ("chao", estaNoChao);
		
	}
	public void addCoins(int value) {
		coins += value;
		
		var coinText = GameObject.Find ("CoinText");
		if (coinText != null) { // Verifica se objeto realmente existe na scene
			var scriptCoinText = coinText.GetComponent<Text>() as Text;
			
			scriptCoinText.text = "x " + coins;
		}
	}
}
