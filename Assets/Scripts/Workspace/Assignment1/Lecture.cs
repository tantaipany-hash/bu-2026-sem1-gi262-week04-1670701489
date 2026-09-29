using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecture : MonoBehaviour
{
    void Start()
    {
        // เอา comment ออกเพื่อรันทดสอบทีละเมธอด
        //LCT01_SyntaxLinkedList();
        // LCT02_SyntaxHashTable();
        // LCT03_SyntaxDictionary();
    }

    public void LCT01_SyntaxLinkedList()
    {
        // 1. สร้างตัวแปร LinkedList ว่าง
        LinkedList<string> list = new LinkedList<string>();

        // 2. เพิ่ม Node ที่ท้ายลิสต์
        list.AddLast("Node 1");
        list.AddLast("Node 2");

        // 3. เพิ่ม Node ที่ต้นลิสต์ แล้วแสดงผล
        list.AddFirst("Node 0");
        Debug.Log("--- Initial LinkedList ---");
        foreach (string node in list)
        {
            Debug.Log(node);
        }

        // 4. อ่านโหนดแรกและสุดท้าย พร้อมใช้ Find ค้นหา
        LinkedListNode<string> firstNode = list.First;
        LinkedListNode<string> lastNode = list.Last;
        Debug.Log($"First Node: {firstNode.Value}");
        Debug.Log($"Last Node: {lastNode.Value}");
        Debug.Log($"firstNode.Previous is null: {firstNode.Previous == null}");
        Debug.Log($"lastNode.Next is null: {lastNode.Next == null}");

        // 5. ค้นหาและแทรกโหนด
        LinkedListNode<string> targetNode = list.Find("Node 1");
        if (targetNode != null)
        {
            list.AddBefore(targetNode, "Before Node 1");
            list.AddAfter(targetNode, "After Node 1");
        }

        // 6. ลบโหนด 0 และ 2 แล้วแสดงผลลัพธ์
        list.RemoveFirst();
        list.Remove("Node 2");

        Debug.Log("--- Final LinkedList ---");
        foreach (string node in list)
        {
            Debug.Log(node);
        }
    }

    public void LCT02_SyntaxHashTable()
    {
        // 1. สร้าง Hashtable
        Hashtable ht = new Hashtable();

        // 2. เพิ่มข้อมูล
        ht.Add(1, "Apple");
        ht.Add(2, "Banana");
        ht.Add("bad-fruit", "Rotten Tomato");

        // 3. อ่านข้อมูลและแปลง (Cast) เป็น string
        Debug.Log($"fruit1: {(string)ht[1]}");
        Debug.Log($"fruit2: {(string)ht[2]}");
        Debug.Log($"badFruit: {(string)ht["bad-fruit"]}");

        // 4. ใช้ foreach อ่าน DictionaryEntry
        Debug.Log("--- All Entries in Hashtable ---");
        foreach (DictionaryEntry entry in ht)
        {
            Debug.Log($"Key: {entry.Key}, Value: {entry.Value}");
        }

        // 5. ตรวจสอบ Key และลบข้อมูล
        bool found2 = ht.ContainsKey(2);
        Debug.Log($"found 2: {found2}");

        ht.Remove(1);

        Debug.Log("--- After removing Key 1 ---");
        foreach (DictionaryEntry entry in ht)
        {
            Debug.Log($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }

    public void LCT03_SyntaxDictionary()
    {
        // 1. สร้าง Dictionary
        Dictionary<int, string> dict = new Dictionary<int, string>();

        // 2. เพิ่มข้อมูลด้วย Add และ Indexer
        dict.Add(1, "Apple");
        dict.Add(2, "Banana");
        dict[3] = "Cherry";

        // 3. แสดงข้อมูลทั้งหมดด้วย KeyValuePair
        Debug.Log($"Dictionary has {dict.Count} keys");
        foreach (KeyValuePair<int, string> kvp in dict)
        {
            Debug.Log($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // 4. ตรวจสอบ Key ด้วย ContainsKey
        bool hasKey1 = dict.ContainsKey(1);
        Debug.Log($"has key 1 : {hasKey1}");
        if (hasKey1)
        {
            Debug.Log($"value of key 1 : {dict[1]}");
        }

        // 5. อ่านและแสดงผล Key ทั้งหมด
        Debug.Log("All keys in dictionary:");
        foreach (int key in dict.Keys)
        {
            Debug.Log(key);
        }

        // 6. ลบ Key 3 และล้างข้อมูลทั้งหมด
        dict.Remove(3);
        Debug.Log($"Dictionary has {dict.Count} keys");

        dict.Clear();
    }
}