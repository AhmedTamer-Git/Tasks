// E-commerce
using ECommerceSystem.DbContect;
using ECommerceSystem.Models;
// Health Care
using HealthCareSystem.DbContect;
using HealthCareSystem.Models;
// Library
using LibrarySystem.DbContect;
using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace D4_Task_Linq_EF
{
    internal class Program
    {
        static void Main()
        {

            #region E-Commerce System LINQ Examples

            Console.WriteLine("\n==============================");
            Console.WriteLine(" E-Commerce System Demo");
            Console.WriteLine("==============================");

            // 1. Create
            using (var ctx = new ECommerceDbContext())
            {
                var category = new Category { Name = "Electronics" };
                ctx.Categories.Add(category);

                var product = new Product { Name = "Laptop", Price = 1200, Category = category };
                ctx.Products.Add(product);

                var customer = new Customer { Name = "Ahmed Ali", Email = "ahmed@test.com" };
                ctx.Customers.Add(customer);

                var order = new Order { Customer = customer, OrderDate = DateTime.Now };
                ctx.Orders.Add(order);

                var detail = new OrderDetail { Order = order, Product = product, Quantity = 2 };
                ctx.OrderDetails.Add(detail);

                ctx.SaveChanges();
            }

            // 2. Read
            using (var ctx = new ECommerceDbContext())
            {
                var orders = ctx.Orders
                                .Include(o => o.Customer)
                                .Include(o => o.OrderDetails)
                                    .ThenInclude(od => od.Product)
                                .ToList();

                foreach (var o in orders)
                {
                    Console.WriteLine($"Order {o.Id} for {o.Customer.Name}:");
                    foreach (var item in o.OrderDetails)
                    {
                        Console.WriteLine($"  {item.Product.Name} x {item.Quantity}");
                    }
                }
            }

            // 3. Update
            using (var ctx = new ECommerceDbContext())
            {
                var customer = ctx.Customers.FirstOrDefault();
                if (customer != null)
                {
                    customer.Name = "Updated Ahmed";
                    ctx.SaveChanges();
                    Console.WriteLine($"Updated Customer: {customer.Name}");
                }
            }

            // 4. Delete
            using (var ctx = new ECommerceDbContext())
            {
                var customer = ctx.Customers.FirstOrDefault();
                if (customer != null)
                {
                    ctx.Customers.Remove(customer);
                    ctx.SaveChanges();
                    Console.WriteLine("Customer deleted.");
                }
            }

            #endregion

            #region Library System LINQ Examples

            Console.WriteLine("\n==============================");
            Console.WriteLine(" Library System Demo");
            Console.WriteLine("==============================");

            // 1. Create
            using (var ctx = new LibraryDbContext())
            {
                var author = new Author { Name = "Naguib Mahfouz", BirthDate = new DateTime(1911, 12, 11) };
                ctx.Authors.Add(author);

                var book = new Book { Title = "Cairo Trilogy", ISBN = "123456789", Author = author };
                ctx.Books.Add(book);

                var borrower = new Borrower { Name = "Sara", MembershipDate = DateTime.Now };
                ctx.Borrowers.Add(borrower);

                var loan = new Loan { Book = book, Borrower = borrower, LoanDate = DateTime.Now };
                ctx.Loans.Add(loan);

                ctx.SaveChanges();
            }

            // 2. Read
            using (var ctx = new LibraryDbContext())
            {
                var borrowers = ctx.Borrowers
                                   .Include(b => b.Loans)
                                       .ThenInclude(l => l.Book)
                                   .ToList();

                foreach (var b in borrowers)
                {
                    Console.WriteLine($"{b.Name} borrowed:");
                    foreach (var loan in b.Loans)
                    {
                        Console.WriteLine($"  {loan.Book.Title} on {loan.LoanDate}");
                    }
                }
            }

            // 3. Update
            using (var ctx = new LibraryDbContext())
            {
                var book = ctx.Books.FirstOrDefault();
                if (book != null)
                {
                    book.Title = "Updated Cairo Trilogy";
                    ctx.SaveChanges();
                    Console.WriteLine($"Updated Book Title: {book.Title}");
                }
            }

            // 4. Delete
            using (var ctx = new LibraryDbContext())
            {
                var borrower = ctx.Borrowers.FirstOrDefault();
                if (borrower != null)
                {
                    ctx.Borrowers.Remove(borrower);
                    ctx.SaveChanges();
                    Console.WriteLine("Borrower deleted.");
                }
            }

            #endregion

            #region Health Care System LINQ Examples

            Console.WriteLine("\n==============================");
            Console.WriteLine(" Health Care System Demo");
            Console.WriteLine("==============================");

            // 1. Create
            using (var ctx = new HealthCareDbContext())
            {
                var patient = new Patient { Name = "Mona", DateOfBirth = new DateTime(1995, 5, 20) };
                ctx.Patients.Add(patient);

                var doctor = new Doctor { Name = "Dr. Khaled", Specialization = "Dermatology" };
                ctx.Doctors.Add(doctor);

                var appointment = new Appointment
                {
                    Patient = patient,
                    Doctor = doctor,
                    AppointmentDate = DateTime.Now.AddDays(1)
                };
                ctx.Appointments.Add(appointment);

                ctx.SaveChanges();
            }

            // 2. Read
            using (var ctx = new HealthCareDbContext())
            {
                var appointments = ctx.Appointments
                                      .Include(a => a.Patient)
                                      .Include(a => a.Doctor)
                                      .ToList();

                foreach (var a in appointments)
                {
                    Console.WriteLine($"{a.Patient.Name} has appointment with {a.Doctor.Name} ({a.Doctor.Specialization}) on {a.AppointmentDate}");
                }
            }

            // 3. Update
            using (var ctx = new HealthCareDbContext())
            {
                var doctor = ctx.Doctors.FirstOrDefault();
                if (doctor != null)
                {
                    doctor.Specialization = "Updated Dermatology";
                    ctx.SaveChanges();
                    Console.WriteLine($"Updated Doctor Specialization: {doctor.Specialization}");
                }
            }

            // 4. Delete
            using (var ctx = new HealthCareDbContext())
            {
                var patient = ctx.Patients.FirstOrDefault();
                if (patient != null)
                {
                    ctx.Patients.Remove(patient);
                    ctx.SaveChanges();
                    Console.WriteLine("Patient deleted.");
                }
            }

            #endregion

        }
    }
}
