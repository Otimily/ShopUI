using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public static ShopItem[] itemDatas =
    {
        new ShopItem("bag1","아이템 1", 10,"공격력 + 1"),
        new ShopItem("bag2","아이템 2", 20,"공격력 + 2"),
        new ShopItem("ch1","아이템 3", 30,"체력 + 6"),
        new ShopItem("ch2","아이템 4", 40,"체력 + 8")
    };


}
