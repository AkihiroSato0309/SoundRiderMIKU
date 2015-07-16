using UnityEngine;
using System.Collections;

public class StateIdle : MikuStateBase
{
	public override void Enter(	GameObject obj, 
								InputEX inputEx, 
								MikuStateManager stateManager,
								MikuAnimationController animationContorller)
	{
		base.Enter (obj, inputEx, stateManager, animationContorller);
		animatorController.ChangeIdle ();
	}

	public override void Execute(GameObject obj)
	{
		if (inputEx.IsTouchFlag == true) 
		{
			stateManager.ChangeState (new StateCrouch());
		}
	}

	public override void Exit (GameObject obj)
	{
	}
}
