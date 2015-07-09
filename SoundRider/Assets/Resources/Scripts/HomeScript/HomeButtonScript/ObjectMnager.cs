using UnityEngine;
using System.Collections;

public class ObjectMnager : MonoBehaviour {

    //Scene
    public GameObject Title;
    public GameObject StageSelect;
    public GameObject Costomize;
    public GameObject Shop;
	
    //どのシーンにいるか
    public int sceneMode = 0;
 
	void Start () {

        //タイトルから始める
        sceneMode = 0;

        //シーンを生成
        Title = GameObject.Find("Title");
        StageSelect = GameObject.Find("StageSelect");
        Costomize = GameObject.Find("Costomize");
        Shop = GameObject.Find("Shop");

        ////タイトルだけを有効化
        Title.SetActive(true);
        StageSelect.SetActive(false);
        Costomize.SetActive(false);
        Shop.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        //タイトルだけを有効化
        if (sceneMode == 0)
        {
            StageSelect.SetActive(false);
            Costomize.SetActive(false);
            Shop.SetActive(false);
            Title.SetActive(true);
        }
        //ステージセレクトだけを有効化
        else if (sceneMode == 1)
        {
            Costomize.SetActive(false);
            Shop.SetActive(false);
            Title.SetActive(false);
            StageSelect.SetActive(true);
        }
        //ショップだけを有効化
        else if (sceneMode == 2)
        {
            Costomize.SetActive(false);
            Title.SetActive(false);
            StageSelect.SetActive(false);
            Shop.SetActive(true);
        }
        //カスタマイズだけを有効化
        else if (sceneMode == 3)
        {
            Title.SetActive(false);
            StageSelect.SetActive(false);
            Shop.SetActive(false);
            Costomize.SetActive(true);
        }
	}
}
