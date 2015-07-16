using UnityEngine;
using System.Collections;

public class CheckGround : MonoBehaviour {

	private MikuOnGame mikuOnGame;
	private bool collisionFlag;

	// 開始処理
	void Start () 
	{
		// 現在の構想階層限定の処理
		mikuOnGame = transform.parent.parent.gameObject.GetComponent<MikuOnGame> ();

		collisionFlag = false;
	}
	
	// 更新処理
	void Update () 
	{

	}

	// 衝突処理
	void OnCollisionEnter2D(Collision2D col)
	{
		mikuOnGame.ChangeIsAirFlag (false);
		collisionFlag = true;
		Debug.Log ("OnGround");
	}

	void OnCollisionExit2D(Collision2D col)
	{
		mikuOnGame.ChangeIsAirFlag (true);
	}
}
