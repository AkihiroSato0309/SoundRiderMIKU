using UnityEngine;
using System.Collections;

public class GUIDebugTest
{
	public static int DEBUG_UI_Y;

	public static int GetUI_Y()
	{
		int tmp = DEBUG_UI_Y;
		DEBUG_UI_Y += 15;
		return tmp;
	}
}
