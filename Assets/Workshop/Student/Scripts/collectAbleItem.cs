using UnityEngine;

namespace Solution
{
    public class CollectAbleItem : Identity
    {
        public int amount = 1;

        public override bool Hit()
        {
            Debug.Log("Item: " + Name + " has been picked up.");

            // เพิ่มไอเท็มเข้า Inventory ของผู้เล่น
            mapGenerator.player.inventory.AddItem(Name, amount);

            // เคลียร์ตำแหน่งเดิมของไอเท็ม และให้ผู้เล่นเดินเข้ามาแทนที่
            mapGenerator.mapdata[positionX, positionY] = null;
            mapGenerator.player.UpdatePosition(positionX, positionY);

            // ทำลายไอเท็มออกจากฉาก
            Destroy(gameObject);

            return true;
        }
    }
}