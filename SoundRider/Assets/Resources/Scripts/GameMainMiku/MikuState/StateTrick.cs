using UnityEngine;
using System.Collections;

public class StateTrick : MikuStateBase 
{
	public override void Enter(	GameObject obj, 
								InputEX inputEx, 
								MikuStateManager stateManager,
								MikuAnimationController animationContorller)
	{
		base.Enter (obj, inputEx, stateManager, animationContorller);
		animatorController.ChangeTrick1 ();
	}

	public override void Execute(GameObject obj)
	{

	}

	public override void Exit (GameObject obj)
	{
	}
}
