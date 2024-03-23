using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2_bt230324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách phòng ban
            var departments = new List<Department>
            {
                new Department(1, "Phong giam doc", "Quan ly cap cao"),
                new Department(2, "Phong marketing", "Quang ba thuong hieu"),
                new Department(3, "Phong ke toan", "Quan ly tai chinh")
            };

            // Tạo danh sách vị trí công việc
            var positions = new List<Position>
            {
                new Position(1, "Truong phong", "Quan ly phong ban"),
                new Position(2, "Nhan vien", "Nhan vien binh thuong"),
                new Position(3, "Ke toan truong", "Truong nhom ke toan")
            };

            // Tạo danh sách nhân viên
            var employees = new List<Employee>
            {
                new Employee(1, "Le Ngoc Hao", 20, positions[0], departments[0]),
                new Employee(2, "Diep Van Ty", 25, positions[1], departments[1]),
                new Employee(3, "Nguyen Cong Huy", 30, positions[2], departments[2])
            };

            // Gán nhân viên vào phòng ban tương ứng
            departments[0].Employees.Add(employees[0]);
            departments[1].Employees.Add(employees[1]);
            departments[2].Employees.Add(employees[2]);

            Console.WriteLine("Nhap tu khoa tim kiem:");
            string keyword = Console.ReadLine();

            Console.WriteLine("Nhap tuoi tu:");
            int minAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap tuoi đen:");
            int maxAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vi tri cong viec:");
            string positionKeyword = Console.ReadLine();

            Console.WriteLine("Nhap ten phong ban:");
            string departmentKeyword = Console.ReadLine();

            var searchResult = employees.Where(e =>
                    (e.Name.Contains(keyword) || e.Position.Name.Contains(keyword) || e.Position.Description.Contains(keyword) ||
                     e.Department.Name.Contains(keyword) || e.Department.Description.Contains(keyword)) &&
                    e.Age >= minAge && e.Age <= maxAge &&
                    (e.Position.Name.Contains(positionKeyword) || e.Position.Description.Contains(positionKeyword)) &&
                    e.Department.Name.Contains(departmentKeyword)).ToList();

            Console.WriteLine("Ket qua tim kiem:");
            foreach (var employee in searchResult)
            {
                Console.WriteLine($"Tên: {employee.Name}, Tuoi: {employee.Age}, Vi tri: {employee.Position.Name}, Phòng ban: {employee.Department.Name}");
            }
        }
    }
}