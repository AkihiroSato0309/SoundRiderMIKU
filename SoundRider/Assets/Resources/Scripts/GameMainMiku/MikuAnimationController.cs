using UnityEngine;
using System.Collections;

public class MikuAnimationController
{

	private Animator controller;

	// アニメーションコントローラーを設定
	public void SetAnimationController(Animator controller)
	{
		this.controller = controller;
	}

	// ジャンプ状態に移行
	public void ChangeJump()
	{
		controller.SetBool ("IsInair", true);
		controller.SetBool ("Tricking1", false);
	}

	// しゃがみ状態に移行
	public void ChangeCroundh()
	{
		controller.SetBool ("IsCrouch", true);
		controller.SetBool ("IsInair", false);
	}

	// アイドル状態に移行
	public void ChangeIdle()
	{
		controller.SetBool ("IsCrouch", false);
		controller.SetBool ("IsInair", false);
	}

	// トリック１に移行
	public void ChangeTrick1()
	{
		controller.SetBool ("Tricking1", true);
	}
}
