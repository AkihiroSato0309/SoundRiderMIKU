using UnityEngine;
using System.Collections;

public class MikuOnGame : MonoBehaviour 
{
	
	private MikuStateManager mikuStateManager;
	private Animator controller;
	private bool isInAir;
	private GameObject mikuMoverPrefab;
	private GameObject mikuMover;
	private GameObject mikuBody;


	private Vector3 downBodyPos;

	public bool IsInAir
	{
		get{return isInAir; }
	}

	// 初期化処理
	void Start () 
	{
		downBodyPos = new Vector2 (0.0f, -0.1f);
		mikuMoverPrefab = Resources.Load ("Prefabs/MikuMover") as GameObject;
		mikuBody = GameObject.Find("Miku");
		controller = mikuBody.GetComponent<Animator> ();
		mikuStateManager = new MikuStateManager (gameObject, controller);

		mikuMover = (GameObject)Instantiate (mikuMoverPrefab, transform.position, transform.rotation);
		mikuMover.name = mikuMoverPrefab.name;
		gameObject.transform.SetParent (mikuMover.transform);
	}

	// 空中にいるかどうかのフラグをチェック
	public void ChangeIsAirFlag(bool flag)
	{
		if (isInAir == flag)
			return;

		isInAir = flag;

		if (isInAir == true) 
		{
			mikuStateManager.ChangeState (new StateInAir());
		}

		if (isInAir == false) 
		{
			mikuStateManager.ChangeState (new StateCrouch ());
			controller.SetTrigger ("CompelIdle");
		}

	}

	// 更新処理
	void Update () 
	{
		// ステートマシーンを回す
		mikuStateManager.Execute ();

		mikuMover.transform.Translate (0.1f, 0.0f, 0.0f);

		// ミクのボディを地面に埋め込ませる
		//transform.position = transform.position + downBodyPos;
	}

	// ジャンプ
	public void Jump()
	{
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (new Vector2(0.0f, 5.0f));
	}

	bool TestFlagChanger()
	{
		return isInAir ? false : true;
	}

	void OnGUI()
	{
		int showX = 0;
		int showY = 450;
		int debugWidth = 70;
		if (GUI.Button (new Rect (showX, showY, debugWidth, 30), "Crouch"))
		{
			ChangeIsAirFlag (TestFlagChanger());
		}
	}
}