using UnityEngine;
using System.Collections;

public class NewObjectManager : MonoBehaviour {

    //ページ(シーンもどき)一覧
    public GameObject Play;
    public GameObject Custom;
    public GameObject Shop;
    public GameObject Option;

    //ミク
    public GameObject MIKU;

    //現在のシーン、ひとつ前のシーン
    public int sceneNow;
    public int scenePre;

    //ページ移動の処理が終わったか判定
    public bool scenePreEnd;
    public bool sceneNowEnd;

	void Start () {
        //初期化(ホームシーン仕様)
        sceneNow = 1;
        scenePre = 0;
        scenePreEnd = true;
        sceneNowEnd = true;
	}
	
	// Update is called once per frame
	void Update () {
	
        //HOME
        if(sceneNow == 1)
        {
            //現在のシーンへ移動完了
            sceneNowEnd = true;

            //もし前のシーンがHOMEなら
            if (scenePre == 1)
            {
                scenePreEnd = true;
            }
            
            //もし前のシーンがPLAYなら
            if (scenePre == 2)
            {
                if (Play.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Play.transform.localPosition += new Vector3(-180, 0, 0);
                    
                    //ミクの移動＆大きさ調整
                    if (scenePre == 2)
                    {
                        MIKU.gameObject.transform.localPosition += new Vector3(50, 25, 0);
                        MIKU.gameObject.transform.localScale += new Vector3(0.05f, 0.05f, 0);
                    }
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Play.transform.localPosition = new Vector3(1080, 0, 0);
                }
            }

            //もし前のシーンがCUSTOMなら
            if (scenePre == 3)
            {
                if (Custom.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Custom.transform.localPosition += new Vector3(-180, 0, 0);
                    
                    //ミクの移動＆大きさ調整
                    if (scenePre == 3)
                    {
                        MIKU.gameObject.transform.localPosition += new Vector3(50, 20, 0);
                        MIKU.gameObject.transform.localScale += new Vector3(0.025f, 0.025f, 0);
                    }
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Custom.transform.localPosition = new Vector3(1080, 0, 0);
                }
            }

            //もし前のシーンがSHOPなら
            if (scenePre == 4)
            {
                if (Shop.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Shop.transform.localPosition += new Vector3(-180, 0, 0);
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Shop.transform.localPosition = new Vector3(1080, 0, 0);
                }

            }

            //もし前のシーンがOPTIONなら
            if (scenePre == 5)
            {
                if (Option.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Option.transform.localPosition += new Vector3(-180, 0, 0);
                  
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Option.transform.localPosition = new Vector3(1080, 0, 0);
                }
            }
        }
        //PLAY
        else if(sceneNow == 2)
        {
            //前のシーンがHOMEかPLAYなら
            if (scenePre == 1 || scenePre == 2)
            {
                scenePreEnd = true;
            }

            //もし前のシーンがCUSTOMなら
            if(scenePre == 3)
            {
                if (Custom.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Custom.transform.localPosition += new Vector3(-180, 0, 0);
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Custom.transform.localPosition = new Vector3(1080, 0, 0);
                }
           
            }

            //もし前のシーンがSHOPなら
            if (scenePre == 4)
            {
                if (Shop.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Shop.transform.localPosition += new Vector3(-180, 0, 0);
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Shop.transform.localPosition = new Vector3(1080, 0, 0);
                }

            }

            //もし前のシーンがOPTIONなら
            if (scenePre == 5)
            {
                if (Option.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Option.transform.localPosition += new Vector3(-180, 0, 0);
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Option.transform.localPosition = new Vector3(1080, 0, 0);
                }
            }

            if (Play.transform.localPosition.x != 0)
            {
                Play.transform.localPosition += new Vector3(-180, 0, 0);

                //ミクの移動＆大きさ調整
                if (scenePre == 1 || scenePre == 4 || scenePre == 5)
                {
                    MIKU.gameObject.transform.localPosition += new Vector3(-50, -25, 0);
                    MIKU.gameObject.transform.localScale += new Vector3(-0.05f, -0.05f, 0);
                }

                if (scenePre == 3)
                {
                    MIKU.gameObject.transform.localPosition += new Vector3(0, -5, 0);
                    MIKU.gameObject.transform.localScale += new Vector3(-0.025f, -0.025f, 0);
                }
            }
            else
            {
                //移動完了
                sceneNowEnd = true;
            }
        }
        //CUSTOM
        else if (sceneNow ==3)
        {
            //もし前のシーンがHOMEかCUSTOMなら
            if (scenePre == 1 || scenePre == 3)
            {
                scenePreEnd = true;
            }

            //もし前のシーンがPLAYなら
            if (scenePre == 2)
            {
                if (Play.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Play.transform.localPosition += new Vector3(-180, 0, 0);
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Play.transform.localPosition = new Vector3(1080, 0, 0);
                }
            }

            //もし前のシーンがSHOPなら
            if (scenePre == 4)
            {
                if (Shop.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Shop.transform.localPosition += new Vector3(-180, 0, 0);
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Shop.transform.localPosition = new Vector3(1080, 0, 0);
                }
            }

            //もし前のシーンがOPTIONなら
            if (scenePre == 5)
            {
                if (Option.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Option.transform.localPosition += new Vector3(-180, 0, 0);
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Option.transform.localPosition = new Vector3(1080, 0, 0);
                }
            }

            if (Custom.transform.localPosition.x != 0)
            {
                Custom.transform.localPosition += new Vector3(-180, 0, 0);
                //ミクの移動＆大きさ調整
                if(scenePre  == 1 ||scenePre  == 4||scenePre  == 5)
                {
                    MIKU.gameObject.transform.localPosition += new Vector3(-50,-20,0);
                    MIKU.gameObject.transform.localScale += new Vector3(-0.025f,-0.025f,0);
                }
                //ミクの移動＆大きさ調整
                if (scenePre == 2)
                {
                    MIKU.gameObject.transform.localPosition += new Vector3(0, 5, 0);
                    MIKU.gameObject.transform.localScale += new Vector3(0.025f, 0.025f, 0);
                }
            }
            else
            {
                //移動完了
                sceneNowEnd = true;
            }
        }
        //SHOP
        else if (sceneNow == 4)
        {
            if (scenePre == 1 || scenePre == 4)
            {
                scenePreEnd = true;
            }

            //もし前のシーンがPLAYなら
            if (scenePre == 2)
            {
                if (Play.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Play.transform.localPosition += new Vector3(-180, 0, 0);

                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Play.transform.localPosition = new Vector3(1080, 0, 0);
                }

            }

            //もし前のシーンがCUSTOMなら
            if (scenePre == 3)
            {
                if (Custom.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Custom.transform.localPosition += new Vector3(-180, 0, 0);
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Custom.transform.localPosition = new Vector3(1080, 0, 0);
                }

            }

            //もし前のシーンがOPTIONなら
            if (scenePre == 5)
            {
                if (Option.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Option.transform.localPosition += new Vector3(-180, 0, 0);
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Option.transform.localPosition = new Vector3(1080, 0, 0);
                }
            }

            if (Shop.transform.localPosition.x != 0)
            {
                Shop.transform.localPosition += new Vector3(-180, 0, 0);
                //ミクの移動＆大きさ調整
                if (scenePre == 3)
                {
                    MIKU.gameObject.transform.localPosition += new Vector3(50, 20, 0);
                    MIKU.gameObject.transform.localScale += new Vector3(0.025f, 0.025f, 0);
                }
                //ミクの移動＆大きさ調整
                if (scenePre == 2)
                {
                    MIKU.gameObject.transform.localPosition += new Vector3(50, 25, 0);
                    MIKU.gameObject.transform.localScale += new Vector3(0.05f, 0.05f, 0);
                }
            }
            else
            {
                //移動完了
                sceneNowEnd = true;
            }
            
        }
        //OPTION
        else if (sceneNow == 5)
        {
            if (scenePre == 1 || scenePre == 5)
            {
                scenePreEnd = true;
            }

            //もし前のシーンがPLAYなら
            if (scenePre == 2)
            {
                if (Play.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Play.transform.localPosition += new Vector3(-180, 0, 0);
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Play.transform.localPosition = new Vector3(1080, 0, 0);
                }
            }

            //もし前のシーンがCUSTOMなら
            if (scenePre == 3)
            {
                if (Custom.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Custom.transform.localPosition += new Vector3(-180, 0, 0);
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Custom.transform.localPosition = new Vector3(1080, 0, 0);
                }
            }

            //もし前のシーンがSHOPなら
            if (scenePre == 4)
            {
                if (Shop.transform.localPosition.x != -1080 && scenePreEnd == false)
                {
                    Shop.transform.localPosition += new Vector3(-180, 0, 0);
                }
                else
                {
                    //移動完了
                    scenePreEnd = true;
                    Shop.transform.localPosition = new Vector3(1080, 0, 0);
                }
            }

            if (Option.transform.localPosition.x != 0)
            {
                Option.transform.localPosition += new Vector3(-180, 0, 0);

                //ミクの移動＆大きさ調整
                if (scenePre == 2)
                {
                    MIKU.gameObject.transform.localPosition += new Vector3(50, 25, 0);
                    MIKU.gameObject.transform.localScale += new Vector3(0.05f, 0.05f, 0);
                }
                //ミクの移動＆大きさ調整
                if (scenePre == 3)
                {
                    MIKU.gameObject.transform.localPosition += new Vector3(50, 20, 0);
                    MIKU.gameObject.transform.localScale += new Vector3(0.025f, 0.025f, 0);
                }
            }
            else
            {
                //移動完了
                sceneNowEnd = true;
            }
        }
	}
}
