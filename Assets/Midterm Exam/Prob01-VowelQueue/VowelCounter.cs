using System;
using System.Collections.Generic;
using System.Linq;

namespace MidtermExam.Prob01
{
    public class VowelCounter
    {
        /// <summary>
        /// ข้อ 01: นับจำนวนสระภาษาอังกฤษตัวพิมพ์เล็กในคิว โดยใช้หลัก FIFO
        /// (สมาชิกที่เข้าก่อนออกก่อน) และรักษาสมาชิกกับลำดับของคิวเดิม
        /// </summary>
        /// <param name="alphabets">
        /// คิวข้อความที่ต้องการตรวจ นับเฉพาะ "a", "e", "i", "o", "u" และนับตัวซ้ำทุกตัว
        /// ข้อความอื่น เช่น "A", "ae", ข้อความว่าง และสมาชิก null ไม่นับเป็นสระ
        /// </param>
        /// <returns>จำนวนสระทั้งหมด หรือ 0 เมื่อคิวเป็น null หรือไม่มีสมาชิก</returns>
        /// <remarks>
        /// ตัวแปร Queue<string> alphabets หลังจากจบ function จะต้องยังคงข้อมูลให้เหมือนเดิมทั้งจำนวนและลำดับ
        /// HINT: อ่านข้อมูลด้วย Dequeue() และใส่กลับด้วย Enqueue() ในคิวที่รับมา
        /// ตัวอย่าง: ["a", "b", "e", "a"] จะต้อง return 3 
        /// และคิวหลังเรียกยังเป็น ["a", "b", "e", "a"] เหมือนเดิม
        /// </remarks>
        public int AS01_CountVowels(Queue<string> alphabets)
        {
            if (alphabets == null || alphabets.Count == 0) return 0;

            var alphabetsQueue = new Queue<string>(alphabets);

            string[] vowels = { "a", "e", "i", "o", "u" };
            int count = 0;
            while (alphabetsQueue.Count > 0)
            {
                string thisChar = alphabetsQueue.Dequeue();
                if (thisChar != null && vowels.Contains(thisChar))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
