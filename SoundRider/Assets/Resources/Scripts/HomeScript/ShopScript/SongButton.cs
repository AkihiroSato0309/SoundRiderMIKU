using UnityEngine;
using System.Collections;

public class SongButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PushButton()
    {
        //ボタンが押されたら歌購入ボタン
        GameObject.Find("Panel").GetComponent<ShopObjectManager>().ShopMode = 0;
    }
}
