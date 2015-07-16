using UnityEngine;
using System.Collections;

public class MikuStateManager{


	// --prvate--------
	private MikuStateBase currentState;		// 今の状態
	private GameObject ownGameObject;		// このステートマシーンを保持しているゲームオブジェクト
	private InputEX inputEx;				// インプットマネージャー
	private MikuAnimationController mikuAnimator;

	// 実行処理
	public void Execute()
	{
		if(currentState != null)currentState.Execute (ownGameObject);
	}


	// ステートを変更
	public void ChangeState(MikuStateBase nextState)
	{
		// 終了関数を呼ぶ
		if(currentState != null)
			currentState.Exit (ownGameObject);

		currentState = nextState;

		currentState.Enter (ownGameObject, inputEx, this, mikuAnimator);
	}

	// コンストラクタ
	public MikuStateManager(GameObject obj,Animator controller)
	{
		ownGameObject = obj;
		mikuAnimator = new MikuAnimationController ();
		mikuAnimator.SetAnimationController (controller);
		inputEx = GameObject.FindGameObjectWithTag ("InputEX").GetComponent<InputEX>();

		// 初期ステートを生成
		ChangeState (new StateIdle());
	}
}

