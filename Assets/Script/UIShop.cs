using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIShop : MonoBehaviour
{
    public Transform itemRoot;

    public Button btnConfirm;
    public Button[] btnItems;
    public Button[] btns;

    public UIShopItem[] uiItems;


    private void Start()
    {
        btns = GetComponentsInChildren<Button>();
        btnConfirm = btns[0];

        //uiItems = GetComponentsInChildren<UIShopItem>();

        for (int i = 0; i < ShopManager.itemDatas.Length; i++)
        {
            ShopItem item = ShopManager.itemDatas[i];
            //uiItems[0].SetItemInfo(item.itemName, item.itemPrice,item.itemBuff); //10��

            //���ҽ� �ε�
            Object itemObject = Resources.Load("btnItem");
            //�ε�� ���� ����
            GameObject itemGameObject = (GameObject)Instantiate(itemObject, itemRoot);

            UIShopItem uIShopItem = itemGameObject.GetComponent<UIShopItem>(); //������ ���ҽ����� �ʿ��� �Ӽ� ã��
            uIShopItem.SetReference();
            uIShopItem.SetItemInfo(item.resName, item.itemName, item.itemPrice, item.itemBuff); // ã���� �Ӽ��� ���� �Է�
        }

    }
}
