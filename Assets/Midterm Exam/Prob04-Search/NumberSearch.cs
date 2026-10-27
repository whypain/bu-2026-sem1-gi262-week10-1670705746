using UnityEngine;

namespace MidtermExam.Prob04
{
    public class NumberSearch
    {
        /// <summary>ข้อ 04.1: ค้นหาตัวเลขด้วย Sequential Search จากต้น array ไปท้าย array</summary>
        /// <param name="values">array ที่อาจไม่เรียงลำดับ มีค่าซ้ำหรือตัวเลขติดลบได้</param>
        /// <param name="target">ค่าที่ต้องการค้นหา</param>
        /// <returns>
        /// - index แรกที่พบ เริ่มนับจาก 0 
        /// - ถ้าไม่พบ หรือ input เป็น null หรือเป็น array ว่าง ให้ return -1</returns>
        /// <remarks>
        /// ห้ามเรียงลำดับหรือแก้ไข array และห้ามใช้เมธอดค้นหาสำเร็จรูปหรือ LINQ
        /// ตัวอย่าง: values = [4, 2, 4, 1], target = 4 ต้องคืน 0 ไม่ใช่ 2
        /// ใช้เวลา O(n) และเขียนคอมเมนต์อธิบายเหตุผลของเวลาที่ใช้เหนือคำตอบ
        /// </remarks>
        public int AS04_SequentialSearch(int[] values, int target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target) return i;
            }

            return -1;
        }

        /// <summary>ข้อ 04.2: ค้นหาตัวเลขด้วย Binary Search โดยลดช่วงค้นหาประมาณครึ่งหนึ่งต่อขั้น</summary>
        /// <param name="sortedValues">
        /// array ที่เรียงจากน้อยไปมากให้แล้ว มีค่าซ้ำหรือตัวเลขติดลบได้ ไม่ต้องตรวจหรือเรียงใหม่
        /// </param>
        /// <param name="target">ค่าที่ต้องการค้นหา</param>
        /// <returns>
        /// index ใดก็ได้ที่มีค่าเท่ากับ target หรือ -1 ถ้าไม่พบ/input เป็น null หรือว่าง
        /// ต่างจาก Sequential Search ในข้อนี้ไม่จำเป็นต้องคืน index แรกของค่าที่ซ้ำ
        /// </returns>
        /// <remarks>
        /// ใช้ลูปหรือ recursion ได้ แต่ห้ามค้นหาแบบไล่ทุกสมาชิกหรือเรียกเมธอดค้นหาสำเร็จรูป
        /// ห้ามแก้ไข array ตัวอย่าง: [1, 2, 2, 2, 5] ค้นหา 2 คืน 1, 2 หรือ 3 ได้
        /// ใช้เวลา O(log n) และเขียนคอมเมนต์อธิบายเหตุผลของเวลาที่ใช้เหนือคำตอบ
        /// </remarks>
        public int AS05_BinarySearch(int[] sortedValues, int target)
        {
            int left = 0;
            int right = sortedValues.Length - 1;
            int mid = right / 2 - 1;

            Debug.Log($"Total: {sortedValues.Length} | Mid: {mid}");

            while (left < right)
            {
                if (target > mid)
                {
                    left = mid;
                    mid = right / 2 - 1;
                }
                else if (target < mid)
                {
                    right = mid;
                    mid = right / 2 - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
