using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShopButton : MonoBehaviour {
    public Image image;
	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {

        //ボタンの色を変える処理(選択されていたら)
        if (GameObject.Find("Canvas").GetComponent<ObjectMnager>().sceneMode == 2)
        {
            image.color = new Color(1.0f, 0.7f, 0.0f, 1.0f);
        }
        else
        {
            image.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
	
	}
    public void PushButton()
    {
        //ボタンが押されたらショップへ行く
        GameObject.Find("Canvas").GetComponent<ObjectMnager>().sceneMode = 2;
    }
}
