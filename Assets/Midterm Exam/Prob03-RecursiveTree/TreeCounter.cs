using System;
using UnityEngine;

namespace MidtermExam.Prob03
{
    public class TreeCounter
    {
        /// <summary>ข้อ 03: นับจำนวนโหนดทั้งหมดใน Binary Tree ด้วยฟังก์ชันเรียกซ้ำ (Recursion)</summary>
        /// <param name="root">โหนดรากของต้นไม้หรือต้นไม้ย่อยที่ต้องการนับ อาจเป็น null</param>
        /// <returns>จำนวนโหนดรวมโหนดราก หรือตัวเลข 0 เมื่อต้นไม้ว่าง</returns>
        /// <remarks>
        /// นับทุกโหนดโดยไม่ขึ้นกับค่า value แม้ค่าซ้ำกันก็ต้องนับเป็นคนละโหนด
        /// ต้องสำรวจทั้งต้นไม้ย่อยซ้ายและขวา โดยไม่แก้ไขค่าหรือการเชื่อมต่อของโหนด
        /// ตัวอย่าง: 
        /// - root node มี child node ซ้ายและขวาอย่างละหนึ่งโหนด คืน 3
        /// - root node (ไม่มี child node ใดๆ) คืน 1
        /// </remarks>
        public int AS03_CountTotalNode(Node root)
        {
            if (root == null) return 0;

            int count = 1;
            count += AS03_CountTotalNode(root.left) + AS03_CountTotalNode(root.right);

            return count;
        }
    }
}
