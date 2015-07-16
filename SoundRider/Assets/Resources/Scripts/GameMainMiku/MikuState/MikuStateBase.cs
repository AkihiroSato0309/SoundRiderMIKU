using UnityEngine;
using System.Collections;

// ミクのベースステート
public class MikuStateBase
{
	//--protected--
	protected InputEX inputEx;
	protected MikuStateManager stateManager;
	protected MikuAnimationController animatorController;

	public virtual void Enter(	GameObject obj, 
								InputEX inputEx, 
								MikuStateManager stateManager,
								MikuAnimationController animationContorller)
	{
		this.inputEx = inputEx;
		this.stateManager = stateManager;
		this.animatorController = animationContorller;
	}

	public virtual void Execute(GameObject obj)
	{
		
	}

	public virtual void Exit (GameObject obj)
	{
	}
}
