using System;
using System.Collections.Generic;

namespace Lab1Bai3
{
    public class People
    {

        public int SID;
        public string TenSV;

        public People()
        {
            SID = 0;
            TenSV = "";

        }

        public People(int SID, String TenSV)
        {
            this.SID = SID;
            this.TenSV = TenSV;
        }

        public void input()
        {
            Console.Write("Nhap ID:");
            SID = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten sinh vien : ");
            TenSV = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
        }
    }
    public class Student : People
    {
        public string Khoa;
        public float DiemTB;

        public Student()
        {
        }

        public Student(int SID, string TenSV, string Khoa, float DiemTB) : base(SID, TenSV)
        {

            this.Khoa = Khoa;
            this.DiemTB = DiemTB;
        }

        public new void input()
        {
            base.input();
            Console.Write("Nhap khoa:");
            Khoa = Console.ReadLine();
            Console.Write("Nhap diem trung binh : ");
            DiemTB = float.Parse(Console.ReadLine());

        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine("Khoa:{0}", this.Khoa);
            Console.WriteLine("Diem TB:{0}", this.DiemTB);
        }
    }
    class Tester
    {
        public static Student Nhap1SV()
        {
            Student a = new Student();
            a.input();
            return a;
        }
        public static List<Student> NhapDS(int n)
        {
            List<Student> DSSV = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                DSSV.Add(Nhap1SV());
            }
            return DSSV;
        }
        public static void XuatSV(List<Student> DSSV)
        {
            foreach (Student sv in DSSV)
                sv.Show();
        }
        public static void Main()
        {
            List<Student> DSSV1 = new List<Student>();
            int n;
            Console.Write("Nhap so luong SV:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            DSSV1 = Tester.NhapDS(n);
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            Tester.XuatSV(DSSV1);
            Console.ReadLine();
        }
    }
}
