using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIShopItem : MonoBehaviour
{
    // �ڱ� �ڽ��� ������ butten
    public Button btnItem;

    // �̹���
    public Image imgItem;

    // text �̸�
    public TMP_Text txtName;

    // text ����
    public TMP_Text txtPrice;

    // text ����
    public TMP_Text txtBuff;

    public void SetReference()
    {
        
        btnItem = GetComponent<Button>();

        // texts - 3
        // 0 : txtItemName
        // 1 : txtItemCost
        // 2 : txtItemOption
        TMP_Text[] TMP_Texts = GetComponentsInChildren<TMP_Text>();


        txtName = TMP_Texts[0];
        txtPrice = TMP_Texts[1];
        txtBuff = TMP_Texts[2];

    }

    public void SetItemInfo(string itemImage, string itemName, int itemPrice, string itemBuff)
    {
        // "Emage/XXX"       
        txtName.text = itemName;
        //txtPrice.text = itemPrice + "g";
        txtPrice.text = $"{itemPrice}";
        txtBuff.text = itemBuff;

        Sprite sprite = Resources.Load<Sprite>("Emage/" + itemImage);
        imgItem.sprite = sprite;
    }

}
