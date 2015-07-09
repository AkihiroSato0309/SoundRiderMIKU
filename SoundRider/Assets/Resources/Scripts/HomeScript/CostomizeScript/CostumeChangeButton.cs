using UnityEngine;
using System.Collections;

public class CostumeChangeButton : MonoBehaviour {

    //コスチュームの番号
	public int coutumeNumber;

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      
	}
    
    public void PushButton () {
	    //ボタンを押したら、コスチュームの番号を送る
        GameObject.Find ("CostumeImage").GetComponent<CostomizeImage> ().costumeNumber = coutumeNumber;
	}
}
