using UnityEngine;
using System.Collections;

public class CostumeButtonScroll : MonoBehaviour {


    //クリックした座標
    private float startPoint;

    //ズレタ座標
    private float BeofPoint;
    Vector3 aaa;
	// Use this for initialization
	void Start () {
        startPoint = 0;
        BeofPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {
	 

        //タップしたとき
        if(Input.GetMouseButtonDown(0))
        {
            startPoint = Input.mousePosition.y;
            Debug.Log("startPoint=" );
            Debug.Log(startPoint);
        }

        //タップ中
        if(Input.GetMouseButton(0))
        {
            BeofPoint = Input.mousePosition.y;
            if(BeofPoint > startPoint)
            {
                aaa = new Vector3(0, (BeofPoint - startPoint), 0);
               
                gameObject.transform.localPosition += aaa;
               
                startPoint = BeofPoint;
            }
            else if (BeofPoint < startPoint)
            {
                aaa = new Vector3(0, (startPoint - BeofPoint), 0);
                if (gameObject.transform.localPosition.y - (startPoint - BeofPoint) > 0)
                gameObject.transform.localPosition -= aaa;
                startPoint = BeofPoint;
            }
        }
        
        //タップ終わり
        if(Input.GetMouseButtonUp(0))
        {
            startPoint = 0;
            BeofPoint = 0;
        }

	}
}
