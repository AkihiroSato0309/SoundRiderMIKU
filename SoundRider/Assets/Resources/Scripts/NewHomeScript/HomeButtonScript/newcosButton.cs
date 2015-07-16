using UnityEngine;
using System.Collections;

public class newcosButton : MonoBehaviour {

    GameObject Home;
    public int sceneNumber;
	// Use this for initialization
	void Start () {

        //ホームを探してくる
        Home = GameObject.Find("Home");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //ボタン押したときの処理
    public void Button()
    {
        //クリックできる状態であれば
        if (Home.GetComponent<NewObjectManager>().sceneNowEnd == true && Home.GetComponent<NewObjectManager>().scenePreEnd == true)
        {
            //クリックできない状態にする(シーン移動が完了していない)
            Home.GetComponent<NewObjectManager>().sceneNowEnd = false;
            Home.GetComponent<NewObjectManager>().scenePreEnd = false;
            
            //シーンを保持
            Home.GetComponent<NewObjectManager>().scenePre = Home.GetComponent<NewObjectManager>().sceneNow;
            Home.GetComponent<NewObjectManager>().sceneNow = sceneNumber;
        }
    }
}
