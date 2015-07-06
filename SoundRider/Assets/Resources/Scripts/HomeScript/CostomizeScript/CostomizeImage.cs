using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CostomizeImage : MonoBehaviour
{

    //コスチューム画像のスプライト(コスチュームの数だけいる？？)
    public Sprite coutume1;
    public Sprite coutume2;
    public Sprite coutume3;
    public Sprite coutume4;
    public Sprite coutume5;

    //現在のコスチュームの番号
    public int costumeNumber;

    //画像変更用のイメージ
    public Image image;

    void Start()
    {

        //コスチューム初期化
        costumeNumber = 1;

        image = GetComponent<Image>();

        //番号ごとにSpriteチェンジ
        if (costumeNumber == 1)
        {
            image.sprite = coutume1;
        }
        else if (costumeNumber == 2)
        {
            image.sprite = coutume2;
        }
        else if (costumeNumber == 3)
        {
            image.sprite = coutume3;
        }
        else if (costumeNumber == 4)
        {
            image.sprite = coutume4;
        }
        else if (costumeNumber == 5)
        {
            image.sprite = coutume5;
        }

    }

    void Update()
    {
        //番号ごとにSpriteチェンジ
        if (costumeNumber == 1)
        {
            image.sprite = coutume1;
        }
        else if (costumeNumber == 2)
        {
            image.sprite = coutume2;
        }
        else if (costumeNumber == 3)
        {
            image.sprite = coutume3;
        }
        else if (costumeNumber == 4)
        {
            image.sprite = coutume4;
        }
        else if (costumeNumber == 5)
        {
            image.sprite = coutume5;
        }
    }
}
