using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : MonoBehaviour
{
    [Header("AS01 Input")]
    public string[] as01Words;

    void Start()
    {
        // เอา comment ออกเพื่อรันทดสอบ
        AS01_CountWords();
    }

    public void AS01_CountWords()
    {
        // 1. สร้าง Dictionary เพื่อเก็บคำและจำนวนนับ
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        // 2. ป้องกันกรณี Array ว่าง
        if (as01Words == null) return;

        // 3-4. วนลูปตรวจเช็คคำและเพิ่ม/อัปเดตจำนวนลง Dictionary
        for (int i = 0; i < as01Words.Length; i++)
        {
            string currentWord = as01Words[i];

            if (wordCount.ContainsKey(currentWord))
            {
                wordCount[currentWord]++;
            }
            else
            {
                wordCount.Add(currentWord, 1);
            }
        }

        // 5. นำ Keys และ Values ไปเป็น Array แล้ววนลูปแสดงผลในตำแหน่งเดียวกัน
        string[] keysArray = new string[wordCount.Count];
        int[] valuesArray = new int[wordCount.Count];

        wordCount.Keys.CopyTo(keysArray, 0);
        wordCount.Values.CopyTo(valuesArray, 0);

        for (int i = 0; i < keysArray.Length; i++)
        {
            Debug.Log($"{keysArray[i]}: {valuesArray[i]}");
        }
    }
}