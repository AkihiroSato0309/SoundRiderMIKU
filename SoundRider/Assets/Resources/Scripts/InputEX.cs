using UnityEngine;
using System.Collections;

/// <summary>
/// 拡張インプットクラス
/// </summary>
public class InputEX : MonoBehaviour
{
	// Direction Enumeration
	public enum eDirection
	{
		Top,
		Bottom,
		Right,
		Left,
		None
	}

	const float BORDE_FLICK = 50.0f;
	float RADIAN_TOP_RIGHT;
	float RADIAN_TOP_LEFT;
	float RADIAN_BOTTOM_RIGHT;
	float RADIAN_BOTTOM_LEFT;

	private Vector2 currentTouchPos;
	private Vector2 lastTouchPos;
	private Vector2 slideVec;
	private float slideAngle;
	private int holdFrame = 0;
	private eDirection slideDirection;

	private float screen2Resolution;

	void Start()
	{
		screen2Resolution = 1920.0f / Screen.width;
		float pi_4 = Mathf.PI / 4.0f;

		// 方向を決定する際に使用する角度を設定
		RADIAN_TOP_RIGHT = pi_4;
		RADIAN_TOP_LEFT = pi_4 * 3.0f;
		RADIAN_BOTTOM_RIGHT = -RADIAN_TOP_RIGHT;
		RADIAN_BOTTOM_LEFT = -RADIAN_TOP_LEFT;

		slideDirection = eDirection.None;
	}


	void Update()
	{
		slideDirection = eDirection.None;
		if (Input.GetMouseButtonDown (0)) 
		{
			holdFrame = 0;
			StartTouch ();
		}
	}



	public Vector2 GetSlideVec()
	{		
		return slideVec;
	}

	// タッチ開始時に呼ぶ関数
	void StartTouch()
	{
		// タッチ中に呼び出すコルーチンを走らせる
		StartCoroutine (Touching());

		// マウスの位置を保存
		lastTouchPos = Screen2ResolutionSize(Input.mousePosition);
	}

	IEnumerator Touching()
	{
		while (true) 
		{
			// ホールドカウント
			holdFrame++;

			currentTouchPos = Screen2ResolutionSize(Input.mousePosition);

			// 前の位置からの差異を保存
			slideVec = currentTouchPos - lastTouchPos;

			// マウスの位置を保存
			lastTouchPos = currentTouchPos;

			yield return null;

			if (Input.GetMouseButtonUp (0)) 
			{
				SetFlickDirection ();
				yield break;
			}
		}
	}
		
	public void SetFlickDirection()
	{
		slideAngle = Mathf.Atan2 (slideVec.y, slideVec.x);
		slideDirection = eDirection.None;

		// スライドが規定ボーダー未満だとNoneを返す
		if (slideVec.magnitude < BORDE_FLICK)
			return;

		// 右方向の検出
		if (slideAngle < RADIAN_TOP_RIGHT &&
		   slideAngle > RADIAN_BOTTOM_RIGHT) 
		{
			slideDirection = eDirection.Right;
		}

		// 上方向の検出
		if (slideAngle > RADIAN_TOP_RIGHT &&
			slideAngle < RADIAN_TOP_LEFT) 
		{
			slideDirection = eDirection.Top;
		}

		// 左方向の検出
		if (slideAngle > RADIAN_TOP_LEFT ||
			slideAngle < RADIAN_BOTTOM_LEFT) 
		{
			slideDirection = eDirection.Left;
		}

		// 下方向の検出
		if (slideAngle < RADIAN_BOTTOM_RIGHT &&
			slideAngle > RADIAN_BOTTOM_LEFT) 
		{
			slideDirection = eDirection.Bottom;
		}
	}

	public eDirection GetFlickDirection()
	{
		return slideDirection;
	}

	// 現在のスクリーン座標から画面座標を割り出す
	Vector2 Screen2ResolutionSize(Vector2 touchPos)
	{
		return touchPos * screen2Resolution;
	}


	// デバッグ表示
	void OnGUI() 
	{
		GUI.Label (new Rect (0, 0, 400, 30), slideAngle.ToString());
		GUI.Label (new Rect(0, 20, 400, 30), "SlideVec : " + slideVec.ToString());
		GUI.Label (new Rect(0, 40, 400, 30), "SlideVecLong : " + slideVec.magnitude.ToString());
		GUI.Label (new Rect(0, 60, 400, 30), "SlideDirection : " + slideDirection.ToString());
	}
}
