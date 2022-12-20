using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem
{
    public string resName;
    public string itemName;
    public int itemPrice;
    public string itemBuff;

    public ShopItem(string image, string name, int price, string buff)
    {
        resName = image;
        itemName = name;
        itemPrice = price;
        itemBuff = buff;
    }
}
