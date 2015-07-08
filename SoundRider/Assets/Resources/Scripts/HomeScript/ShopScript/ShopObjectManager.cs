using UnityEngine;
using System.Collections;

public class ShopObjectManager : MonoBehaviour {
   
    //ショップ内のページ
    public GameObject Song;
    public GameObject Costume;
    public GameObject Trick;

    //どのページにいるか
    public int ShopMode = 0;

    // Use this for initialization
	void Start () {
    
        //ページの取得
        Song = GameObject.Find("SoundShop");
        Costume = GameObject.Find("CostumeShop");
        Trick = GameObject.Find("TrickShop");
        
        //ショップが歌購入画面
        if (ShopMode == 0)
        {
            Song.transform.SetAsLastSibling();
            Costume.transform.SetAsFirstSibling();
            Trick.transform.SetAsFirstSibling();
        }
        //ショップがコスチューム購入画面
        else if (ShopMode == 1)
        {
            Song.transform.SetAsFirstSibling();
            Costume.transform.SetAsLastSibling();
            Trick.transform.SetAsFirstSibling();
        }
        //ショップがトリック画面
        else if (ShopMode == 2)
        {
            Song.transform.SetAsFirstSibling();
            Costume.transform.SetAsFirstSibling();
            Trick.transform.SetAsLastSibling();
        }
	}
	
	// Update is called once per frame
	void Update () {

        //ショップが歌購入画面
        if (ShopMode == 0)
        {
            Song.transform.SetAsLastSibling();
            Costume.transform.SetAsFirstSibling();
            Trick.transform.SetAsFirstSibling();
        }
        //ショップがコスチューム購入画面
        else if (ShopMode == 1)
        {
            Song.transform.SetAsFirstSibling();
            Costume.transform.SetAsLastSibling();
            Trick.transform.SetAsFirstSibling();
        }
        //ショップがトリック画面
        else if (ShopMode == 2)
        {
            Song.transform.SetAsFirstSibling();
            Costume.transform.SetAsFirstSibling();
            Trick.transform.SetAsLastSibling();
        }

	}
}
