using UnityEngine;
using System.Collections;

public class TrickButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PushButton()
    {
        //ボタンが押されたらトリック購入ボタン
        GameObject.Find("Panel").GetComponent<ShopObjectManager>().ShopMode = 2;
    }
}
