using UnityEngine;
using System.Collections;

public class CostumeButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void PushButton()
    {
        //ボタンが押されたらコスチューム購入ボタン
        GameObject.Find("Panel").GetComponent<ShopObjectManager>().ShopMode = 1;
    }
}
