using UnityEngine;
using System.Collections;

public class StateCrouch : MikuStateBase
{
	public override void Enter(	GameObject obj, 
								InputEX inputEx, 
								MikuStateManager stateManager,
								MikuAnimationController animationContorller)
	{
		base.Enter (obj, inputEx, stateManager, animationContorller);
		animatorController.ChangeCroundh ();
	}

	public override void Execute(GameObject obj)
	{
		if (inputEx.SlideDirection == InputEX.eDirection.Top) 
		{
			stateManager.ChangeState (new StateInAir ());
			Debug.Log(obj.name);
			Rigidbody2D rb = obj.GetComponent<Rigidbody2D> ();
			rb.AddForce (new Vector2(0.0f, 30.0f));
			return;
		}

		if (inputEx.IsTouchFlag == false) 
		{
			stateManager.ChangeState (new StateIdle());
			return;
		}

	}

	public override void Exit (GameObject obj)
	{
	}
}
