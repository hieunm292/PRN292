using System;

namespace Lab1Bai2
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        public Student()
        {
        }

        public Student(Student stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }

        public Student(int sID, string tenSV, string khoa, float diemTB)
        {
            SID = sID;
            TenSV = tenSV;
            Khoa = khoa;
            DiemTB = diemTB;
        }

        public int StudentID //Property dai dien cho thuoc tinh SID
        {
            get { return SID; } //Lay du lieu
            set { SID = value; } //Gan du lieu
        }
        public String Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public String Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }

        public void Input()
        {
            Console.WriteLine("Enter your ID :");
            SID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your name :");
            TenSV = Console.ReadLine();
            Console.WriteLine("Enter your subject :");
            Khoa = Console.ReadLine();
            Console.WriteLine("Enter your Average Mark :");
            DiemTB = float.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine("ID : {0}" + this.SID);
            Console.WriteLine("Student Name : {0}" + this.TenSV);
            Console.WriteLine("Subject  : {0}" + this.Khoa);
            Console.WriteLine("Average Mark : {0}" + this.DiemTB);
        }
    }

    class Test
    {
        public static Student Nhap1SV()
        {
            Student a = new Student();
            a.Input();
            return a;
        }
        public static Student[] NhapDS(int n)
        {
            Student[] DSSV;
            DSSV = new Student[n];
            for (int i = 0; i < n; i++)
            {

                DSSV[i] = Nhap1SV();
            }
            return DSSV;
        }
        public static void XuatSV(Student[] DSSV)
        {
            foreach (Student sv in DSSV)
                sv.Show();
        }
        public static void Main()
        {
            Student[] DSSV1;
            int n;
            Console.Write("Nhap so luong SV:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            DSSV1 = Test.NhapDS(n);
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            Test.XuatSV(DSSV1);
            Console.ReadLine();
        }
    }
}
