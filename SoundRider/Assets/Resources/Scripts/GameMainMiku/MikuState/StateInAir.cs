using UnityEngine;
using System.Collections;

public class StateInAir : MikuStateBase 
{
	public override void Enter(	GameObject obj, 
								InputEX inputEx, 						
								MikuStateManager stateManager,
								MikuAnimationController animationContorller)
	{
		base.Enter (obj, inputEx, stateManager, animationContorller);
		animatorController.ChangeJump ();
	}

	public override void Execute(GameObject obj)
	{
		if (inputEx.SlideDirection == InputEX.eDirection.Right) 
		{
			stateManager.ChangeState (new StateTrick());
		}
	}

	public override void Exit (GameObject obj)
	{
	}
}
