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

	// 使用定数
	const float BORDE_FLICK = 50.0f;
	private float RADIAN_TOP_RIGHT;
	private float RADIAN_TOP_LEFT;
	private float RADIAN_BOTTOM_RIGHT;
	private float RADIAN_BOTTOM_LEFT;


	private Vector2 currentTouchPos;		// 現在のタッチ座標
	private Vector2 lastTouchPos;			// 最後にタッチした座標
	private Vector2 slideVec;				// スライド方向
	private float slideAngle;				// スライドした角度
	private float holdSecond = 0.0f;		// タッチ中のカウント
	private eDirection slideDirection;		// スライド方向の向き
	private float screen2Resolution;		// スクリーン座標を解像度座標に変換
	private bool isTouchFlag = false;		// タッチしている時はtrue

	// プロパティ
	public bool IsTouchFlag
	{
		get{ return isTouchFlag;}
	}

	public Vector2 SlideVec
	{
		get{ return slideVec; }
	}

	public eDirection SlideDirection
	{
		get{ return slideDirection; }
	}


	// 開始処理
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

	// 更新処理
	void Update()
	{
		slideDirection = eDirection.None;
		if (Input.GetMouseButtonDown (0)) 
		{
			holdSecond = 0;
			StartTouch ();
		}
	}

	// タッチ開始時に呼ぶ関数
	void StartTouch()
	{
		// タッチ中に呼び出すコルーチンを走らせる
		StartCoroutine (Touching());

		// マウスの位置を保存
		lastTouchPos = Screen2ResolutionSize(Input.mousePosition);

		// タッチフラグを立てる
		isTouchFlag = true;
	}


	// タッチしている時に呼ばれる関数
	IEnumerator Touching()
	{
		while (true) 
		{
			// ホールドカウント
			holdSecond += Time.deltaTime;

			currentTouchPos = Screen2ResolutionSize(Input.mousePosition);

			// 前の位置からの差異を保存
			slideVec = currentTouchPos - lastTouchPos;

			// マウスの位置を保存
			lastTouchPos = currentTouchPos;

			yield return null;


			// タッチを離す時
			if (Input.GetMouseButtonUp (0)) 
			{
				SetFlickDirection ();
				isTouchFlag = false;
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

	// 現在のスクリーン座標から画面座標を割り出す
	Vector2 Screen2ResolutionSize(Vector2 touchPos)
	{
		return touchPos * screen2Resolution;
	}


	// デバッグ表示
	void OnGUI() 
	{
		int showY = 0;
		GUI.Label (new Rect(0, showY, 400, 30), slideAngle.ToString());
		GUI.Label (new Rect(0, showY += 15, 400, 30), "SlideVec : " + slideVec.ToString());
		GUI.Label (new Rect(0, showY += 15, 400, 30), "SlideVecLong : " + slideVec.magnitude.ToString());
		GUI.Label (new Rect(0, showY += 15, 400, 30), "SlideDirection : " + slideDirection.ToString());
		GUI.Label (new Rect(0, showY += 15, 400, 30), "TouchCount : " + holdSecond.ToString());
	}
}
