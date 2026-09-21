using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Solution
{
    public class OOPExit : Identity
    {
        public GameObject YouWin;

        // กำหนดชื่อไอเท็มและจำนวนที่ต้องการใช้ในการเปิดทางออก
        [Header("Exit Requirements")]
        public string requiredItemName = "Key";
        public int requiredAmount = 1;

        public override bool Hit()
        {
            // ตรวจสอบว่าผู้เล่นมีไอเท็มที่ต้องการหรือไม่
            if (mapGenerator.player.inventory.HasItem(requiredItemName, requiredAmount))
            {
                // หากจะให้ใช้ไอเท็มแล้วหายไป ให้เปิดใช้งานคำสั่งบรรทัดล่าง
                // mapGenerator.player.inventory.RemoveItem(requiredItemName, requiredAmount);

                YouWin.SetActive(true);
                Debug.Log("You win");

                // อัปเดตตำแหน่งผู้เล่นไปที่ทางออก
                mapGenerator.mapdata[positionX, positionY] = null;
                mapGenerator.player.UpdatePosition(positionX, positionY);

                return true;
            }
            else
            {
                Debug.Log("You need " + requiredAmount + " " + requiredItemName + " to open this exit!");
                return false;
            }
        }
    }
}