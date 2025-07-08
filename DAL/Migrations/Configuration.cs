namespace DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.TPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.TPContext context)
        {
            //            var users = new List<EF.Tables.User>
            //            {
            //    new EF.Tables.User { UserID = 1, Name = "Sakib", Email = "sakib@gmail.com", Password = "1234" },
            //    new EF.Tables.User { UserID = 2, Name = "Mariam", Email = "mariam123@gmail.com", Password = "pass123" },
            //    new EF.Tables.User { UserID = 3, Name = "Arif", Email = "arif.b@gmail.com", Password = "secure456" },
            //    new EF.Tables.User { UserID = 4, Name = "Nadia", Email = "nadia_98@gmail.com", Password = "mypassword" },
            //    new EF.Tables.User { UserID = 5, Name = "Rafi", Email = "rafi2023@gmail.com", Password = "qwerty" },
            //    new EF.Tables.User { UserID = 6, Name = "Tania", Email = "tania.khan@gmail.com", Password = "letmein" },
            //    new EF.Tables.User { UserID = 7, Name = "Hasan", Email = "hasan77@gmail.com", Password = "welcome" },
            //    new EF.Tables.User { UserID = 8, Name = "Lubna", Email = "lubna.c@gmail.com", Password = "hello123" },
            //    new EF.Tables.User { UserID = 9, Name = "Farhan", Email = "farhan_m@gmail.com", Password = "abc123" },
            //    new EF.Tables.User { UserID = 10, Name = "Ayesha", Email = "ayesha.star@gmail.com", Password = "password1" }
            //};

            //            foreach (var user in users)
            //            {
            //                context.Users.Add(user);
            //            }
            //            context.SaveChanges();
            //            var Trip = new List<EF.Tables.Trip>
            //{
            //    new EF.Tables.Trip { TripID = 1, UserID = 12, TripName = "Beach Vacation", Destination = "Maldives", StartDate = DateTime.Parse("2025-05-10"), EndDate = DateTime.Parse("2025-05-17"), ItinerarySummary = "Enjoy a relaxing week on the beaches of Maldives.", TravelMode = "Flight", Rating = 4.5 },
            //    new EF.Tables.Trip { TripID = 2, UserID = 13, TripName = "Mountain Adventure", Destination = "Switzerland", StartDate = DateTime.Parse("2025-06-01"), EndDate = DateTime.Parse("2025-06-10"), ItinerarySummary = "Hiking, skiing, and mountain exploration in Switzerland.", TravelMode = "Train", Rating = 4.8 },
            //    new EF.Tables.Trip { TripID = 3, UserID = 13, TripName = "City Break", Destination = "Paris", StartDate = DateTime.Parse("2025-04-20"), EndDate = DateTime.Parse("2025-04-23"), ItinerarySummary = "Explore the iconic landmarks of Paris including the Eiffel Tower.", TravelMode = "Flight", Rating = 4.7 },
            //    new EF.Tables.Trip { TripID = 4, UserID = 14, TripName = "Cultural Journey", Destination = "Kyoto", StartDate = DateTime.Parse("2025-03-15"), EndDate = DateTime.Parse("2025-03-22"), ItinerarySummary = "A week exploring the temples and traditions of Kyoto.", TravelMode = "Flight", Rating = 4.6 },
            //    new EF.Tables.Trip { TripID = 5, UserID = 5, TripName = "Safari Expedition", Destination = "Kenya", StartDate = DateTime.Parse("2025-07-05"), EndDate = DateTime.Parse("2025-07-15"), ItinerarySummary = "Experience the wild side of Kenya on a safari adventure.", TravelMode = "Flight", Rating = 5.0 },
            //    new EF.Tables.Trip { TripID = 6, UserID = 6, TripName = "Historical Tour", Destination = "Rome", StartDate = DateTime.Parse("2025-08-10"), EndDate = DateTime.Parse("2025-08-14"), ItinerarySummary = "Discover the history of ancient Rome and visit the Colosseum.", TravelMode = "Flight", Rating = 4.3 },
            //    new EF.Tables.Trip { TripID = 7, UserID = 7, TripName = "Island Escape", Destination = "Bora Bora", StartDate = DateTime.Parse("2025-09-05"), EndDate = DateTime.Parse("2025-09-12"), ItinerarySummary = "Relax on the beautiful beaches of Bora Bora with crystal-clear waters.", TravelMode = "Flight", Rating = 4.9 },
            //    new EF.Tables.Trip { TripID = 8, UserID = 8, TripName = "Adventure in the Wild", Destination = "Canada", StartDate = DateTime.Parse("2025-10-01"), EndDate = DateTime.Parse("2025-10-07"), ItinerarySummary = "Go on a wild adventure in the Canadian wilderness with canoeing and hiking.", TravelMode = "Car", Rating = 4.2 },
            //    new EF.Tables.Trip { TripID = 9, UserID = 9, TripName = "Tropical Retreat", Destination = "Bali", StartDate = DateTime.Parse("2025-12-01"), EndDate = DateTime.Parse("2025-12-10"), ItinerarySummary = "Enjoy the tropical beauty of Bali and its serene beaches.", TravelMode = "Flight", Rating = 4.8 },
            //    new EF.Tables.Trip { TripID = 10, UserID = 10, TripName = "European Road Trip", Destination = "France, Italy, Germany", StartDate = DateTime.Parse("2025-06-25"), EndDate = DateTime.Parse("2025-07-05"), ItinerarySummary = "A road trip across Europe, visiting multiple countries in one go.", TravelMode = "Car", Rating = 4.5 },
            //    new EF.Tables.Trip { TripID = 11, UserID = 13, TripName = "Relaxing Beach Vacation", Destination = "Thailand", StartDate = DateTime.Parse("2025-01-15"), EndDate = DateTime.Parse("2025-01-22"), ItinerarySummary = "Enjoy a laid-back beach holiday in Thailand.", TravelMode = "Flight", Rating = 4.6 },
            //    new EF.Tables.Trip { TripID = 12, UserID = 5, TripName = "Trekking Adventure", Destination = "Nepal", StartDate = DateTime.Parse("2025-04-01"), EndDate = DateTime.Parse("2025-04-10"), ItinerarySummary = "Trek the Himalayas and explore the remote regions of Nepal.", TravelMode = "Flight", Rating = 4.8 },
            //    new EF.Tables.Trip { TripID = 13, UserID = 7, TripName = "City Tour", Destination = "New York", StartDate = DateTime.Parse("2025-02-10"), EndDate = DateTime.Parse("2025-02-15"), ItinerarySummary = "Tour the iconic landmarks of New York City, from Times Square to Central Park.", TravelMode = "Train", Rating = 4.7 },
            //    new EF.Tables.Trip { TripID = 14, UserID = 12, TripName = "Luxury Cruise", Destination = "Caribbean", StartDate = DateTime.Parse("2025-03-01"), EndDate = DateTime.Parse("2025-03-10"), ItinerarySummary = "Set sail on a luxury cruise through the Caribbean islands.", TravelMode = "Cruise", Rating = 5.0 },
            //    new EF.Tables.Trip { TripID = 15, UserID = 14, TripName = "Cultural Exploration", Destination = "India", StartDate = DateTime.Parse("2025-07-10"), EndDate = DateTime.Parse("2025-07-20"), ItinerarySummary = "Immerse yourself in the culture, food, and heritage of India.", TravelMode = "Flight", Rating = 4.4 },
            //    new EF.Tables.Trip { TripID = 16, UserID = 6, TripName = "Winter Wonderland", Destination = "Finland", StartDate = DateTime.Parse("2025-11-15"), EndDate = DateTime.Parse("2025-11-22"), ItinerarySummary = "Explore the snowy landscapes of Finland and enjoy winter sports.", TravelMode = "Flight", Rating = 4.6 },
            //    new EF.Tables.Trip { TripID = 17, UserID = 9, TripName = "Desert Safari", Destination = "Dubai", StartDate = DateTime.Parse("2025-08-05"), EndDate = DateTime.Parse("2025-08-12"), ItinerarySummary = "Experience a thrilling desert safari and city tour in Dubai.", TravelMode = "Flight", Rating = 4.3 },
            //    new EF.Tables.Trip { TripID = 18, UserID = 10, TripName = "Cruise to Alaska", Destination = "Alaska", StartDate = DateTime.Parse("2025-06-20"), EndDate = DateTime.Parse("2025-06-27"), ItinerarySummary = "Set off on a scenic cruise through Alaska’s glaciers and coastline.", TravelMode = "Cruise", Rating = 4.9 },
            //    new EF.Tables.Trip { TripID = 19, UserID = 8, TripName = "Volcano Tour", Destination = "Iceland", StartDate = DateTime.Parse("2025-05-20"), EndDate = DateTime.Parse("2025-05-25"), ItinerarySummary = "Explore the volcanic landscapes of Iceland with a guided tour.", TravelMode = "Flight", Rating = 4.7 },
            //    new EF.Tables.Trip { TripID = 20, UserID = 10, TripName = "Tropical Island Adventure", Destination = "Hawaii", StartDate = DateTime.Parse("2025-09-10"), EndDate = DateTime.Parse("2025-09-17"), ItinerarySummary = "Discover the beauty of Hawaii with its stunning beaches and activities.", TravelMode = "Flight", Rating = 4.8 }
            //};

            //            foreach (var trip in Trip)
            //            {
            //                context.Trip.Add(trip); // Add trip to the Trip table
            //            }

            //            // Save changes to the database
            //            context.SaveChanges();

            //            var budgets = new List<EF.Tables.Budget>
            //{
            //    new EF.Tables.Budget { BudgetID = 1, TripID = 22, Category = "Accommodation", EstimatedCost = 5000.0, ActualCost = 8000.0 },
            //    new EF.Tables.Budget { BudgetID = 2, TripID = 22, Category = "Food", EstimatedCost = 3000.0, ActualCost = 3500.0 },
            //    new EF.Tables.Budget { BudgetID = 3, TripID = 22, Category = "Transportation", EstimatedCost = 2000.0, ActualCost = 1800.0 },
            //    new EF.Tables.Budget { BudgetID = 4, TripID = 23, Category = "Accommodation", EstimatedCost = 7000.0, ActualCost = 7500.0 },
            //    new EF.Tables.Budget { BudgetID = 5, TripID = 23, Category = "Food", EstimatedCost = 4000.0, ActualCost = 4200.0 },
            //    new EF.Tables.Budget { BudgetID = 6, TripID = 23, Category = "Activities", EstimatedCost = 3000.0, ActualCost = 3100.0 },
            //    new EF.Tables.Budget { BudgetID = 7, TripID = 23, Category = "Transportation", EstimatedCost = 2500.0, ActualCost = 2400.0 },
            //    new EF.Tables.Budget { BudgetID = 8, TripID = 24, Category = "Food", EstimatedCost = 2000.0, ActualCost = 2200.0 },
            //    new EF.Tables.Budget { BudgetID = 9, TripID = 25, Category = "Accommodation", EstimatedCost = 4500.0, ActualCost = 4700.0 },
            //    new EF.Tables.Budget { BudgetID = 10, TripID = 26, Category = "Activities", EstimatedCost = 5000.0, ActualCost = 5300.0 },
            //    new EF.Tables.Budget { BudgetID = 11, TripID = 26, Category = "Food", EstimatedCost = 3500.0, ActualCost = 3400.0 },
            //    new EF.Tables.Budget { BudgetID = 12, TripID = 26, Category = "Accommodation", EstimatedCost = 8000.0, ActualCost = 8500.0 },
            //    new EF.Tables.Budget { BudgetID = 13, TripID = 27, Category = "Transportation", EstimatedCost = 6000.0, ActualCost = 6200.0 },
            //    new EF.Tables.Budget { BudgetID = 14, TripID = 28, Category = "Activities", EstimatedCost = 4000.0, ActualCost = 3800.0 },
            //    new EF.Tables.Budget { BudgetID = 15, TripID = 29, Category = "Food", EstimatedCost = 2000.0, ActualCost = 2100.0 },
            //    new EF.Tables.Budget { BudgetID = 16, TripID = 29, Category = "Accommodation", EstimatedCost = 7000.0, ActualCost = 7500.0 },
            //    new EF.Tables.Budget { BudgetID = 17, TripID = 30, Category = "Transportation", EstimatedCost = 3000.0, ActualCost = 2900.0 },
            //    new EF.Tables.Budget { BudgetID = 18, TripID = 31, Category = "Activities", EstimatedCost = 4500.0, ActualCost = 4700.0 },
            //    new EF.Tables.Budget { BudgetID = 19, TripID = 32, Category = "Food", EstimatedCost = 2500.0, ActualCost = 2600.0 },
            //    new EF.Tables.Budget { BudgetID = 20, TripID = 36, Category = "Transportation", EstimatedCost = 3500.0, ActualCost = 3600.0 },
            //    new EF.Tables.Budget { BudgetID = 21, TripID = 36, Category = "Food", EstimatedCost = 3000.0, ActualCost = 3100.0 },
            //    new EF.Tables.Budget { BudgetID = 22, TripID = 36, Category = "Accommodation", EstimatedCost = 9000.0, ActualCost = 9100.0 },
            //    new EF.Tables.Budget { BudgetID = 23, TripID = 36, Category = "Activities", EstimatedCost = 4000.0, ActualCost = 4200.0 },
            //    new EF.Tables.Budget { BudgetID = 24, TripID = 37, Category = "Transportation", EstimatedCost = 5000.0, ActualCost = 4900.0 },
            //    new EF.Tables.Budget { BudgetID = 25, TripID = 37, Category = "Food", EstimatedCost = 3500.0, ActualCost = 3400.0 },
            //    new EF.Tables.Budget { BudgetID = 26, TripID = 38, Category = "Accommodation", EstimatedCost = 7000.0, ActualCost = 7300.0 },
            //    new EF.Tables.Budget { BudgetID = 27, TripID = 39, Category = "Transportation", EstimatedCost = 4500.0, ActualCost = 4600.0 },
            //    new EF.Tables.Budget { BudgetID = 28, TripID = 39, Category = "Activities", EstimatedCost = 3000.0, ActualCost = 3100.0 },
            //    new EF.Tables.Budget { BudgetID = 29, TripID = 40, Category = "Food", EstimatedCost = 4000.0, ActualCost = 4200.0 },
            //    new EF.Tables.Budget { BudgetID = 30, TripID = 40, Category = "Accommodation", EstimatedCost = 8500.0, ActualCost = 8700.0 }
            //};

            //            // Add each budget to the database
            //            foreach (var budget in budgets)
            //            {
            //                context.Budgets.Add(budget); // Add budget to the Budgets table
            //            }

            //            // Save changes to the database
            //            context.SaveChanges();

            //            var Packings = new List<EF.Tables.Packing>
            //{
            //    new EF.Tables.Packing { PackingItemID = 1, TripID = 22, ItemName = "Cloth", Quantity = 5, Priority = "High", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 2, TripID = 22, ItemName = "Toothbrush", Quantity = 1, Priority = "Medium", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 3, TripID = 23, ItemName = "Shoes", Quantity = 2, Priority = "High", IsPacked = false },
            //    new EF.Tables.Packing { PackingItemID = 4, TripID = 23, ItemName = "Sunscreen", Quantity = 1, Priority = "High", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 5, TripID = 24, ItemName = "Travel Adapter", Quantity = 1, Priority = "Medium", IsPacked = false },
            //    new EF.Tables.Packing { PackingItemID = 6, TripID = 24, ItemName = "Camera", Quantity = 1, Priority = "High", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 7, TripID = 25, ItemName = "First Aid Kit", Quantity = 1, Priority = "High", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 8, TripID = 25, ItemName = "Books", Quantity = 3, Priority = "Low", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 9, TripID = 26, ItemName = "Snacks", Quantity = 10, Priority = "Medium", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 10, TripID = 26, ItemName = "Umbrella", Quantity = 1, Priority = "High", IsPacked = false },
            //    new EF.Tables.Packing { PackingItemID = 11, TripID = 27, ItemName = "Jacket", Quantity = 2, Priority = "High", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 12, TripID = 27, ItemName = "Hat", Quantity = 1, Priority = "Low", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 13, TripID = 28, ItemName = "Sunglasses", Quantity = 1, Priority = "Medium", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 14, TripID = 28, ItemName = "Swimsuit", Quantity = 2, Priority = "High", IsPacked = false },
            //    new EF.Tables.Packing { PackingItemID = 15, TripID = 29, ItemName = "Power Bank", Quantity = 1, Priority = "High", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 16, TripID = 29, ItemName = "Passport", Quantity = 1, Priority = "High", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 17, TripID = 30, ItemName = "Notebook", Quantity = 2, Priority = "Medium", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 18, TripID = 30, ItemName = "Pens", Quantity = 5, Priority = "Low", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 19, TripID = 31, ItemName = "Headphones", Quantity = 1, Priority = "Medium", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 20, TripID = 31, ItemName = "Phone Charger", Quantity = 1, Priority = "High", IsPacked = false },
            //    new EF.Tables.Packing { PackingItemID = 21, TripID = 32, ItemName = "Lotion", Quantity = 1, Priority = "Medium", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 22, TripID = 32, ItemName = "Face Mask", Quantity = 5, Priority = "Low", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 23, TripID = 33, ItemName = "Gloves", Quantity = 2, Priority = "Medium", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 24, TripID = 33, ItemName = "Lip Balm", Quantity = 1, Priority = "Low", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 25, TripID = 34, ItemName = "Hand Sanitizer", Quantity = 2, Priority = "High", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 26, TripID = 34, ItemName = "Medicines", Quantity = 1, Priority = "High", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 27, TripID = 35, ItemName = "Tablet", Quantity = 1, Priority = "Medium", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 28, TripID = 35, ItemName = "Laptop", Quantity = 1, Priority = "High", IsPacked = false },
            //    new EF.Tables.Packing { PackingItemID = 29, TripID = 36, ItemName = "Neck Pillow", Quantity = 1, Priority = "Medium", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 30, TripID = 36, ItemName = "Travel Guide", Quantity = 1, Priority = "Low", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 31, TripID = 37, ItemName = "Water Bottle", Quantity = 3, Priority = "High", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 32, TripID = 37, ItemName = "Snacks", Quantity = 5, Priority = "Medium", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 33, TripID = 38, ItemName = "Tickets", Quantity = 1, Priority = "High", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 34, TripID = 38, ItemName = "Map", Quantity = 1, Priority = "Low", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 35, TripID = 39, ItemName = "Binoculars", Quantity = 1, Priority = "Medium", IsPacked = false },
            //    new EF.Tables.Packing { PackingItemID = 36, TripID = 39, ItemName = "Towel", Quantity = 2, Priority = "High", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 37, TripID = 40, ItemName = "Soap", Quantity = 1, Priority = "Medium", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 38, TripID = 40, ItemName = "Shampoo", Quantity = 1, Priority = "Medium", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 39, TripID = 41, ItemName = "Blanket", Quantity = 1, Priority = "High", IsPacked = true },
            //    new EF.Tables.Packing { PackingItemID = 40, TripID = 41, ItemName = "Slippers", Quantity = 1, Priority = "Low", IsPacked = true }
            //};

            //            // Add each packing item to the database
            //            foreach (var item in Packings)
            //            {
            //                context.Packings.Add(item); // Add packing item to the Packings table
            //            }

            //            // Save changes to the database
            //            context.SaveChanges();
//            var trips = new List<EF.Tables.Trip>
//{
//    new EF.Tables.Trip { TripID = 11, UserID = 5, TripName = "Beach Vacation", Destination = "Maldives", StartDate = DateTime.Parse("2024-08-10"), EndDate = DateTime.Parse("2024-08-17"), ItinerarySummary = "Enjoy a relaxing week on the beaches of Maldives.", TravelMode = "Flight", Rating = 4.5, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 12, UserID = 13, TripName = "Mountain Adventure", Destination = "Switzerland", StartDate = DateTime.Parse("2024-07-01"), EndDate = DateTime.Parse("2024-07-10"), ItinerarySummary = "Hiking, skiing, and mountain exploration in Switzerland.", TravelMode = "Train", Rating = 4.8, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 13, UserID = 14, TripName = "City Break", Destination = "Paris", StartDate = DateTime.Parse("2024-06-20"), EndDate = DateTime.Parse("2024-06-23"), ItinerarySummary = "Explore the iconic landmarks of Paris including the Eiffel Tower.", TravelMode = "Flight", Rating = 4.7, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 14, UserID = 5, TripName = "Cultural Journey", Destination = "Kyoto", StartDate = DateTime.Parse("2024-05-15"), EndDate = DateTime.Parse("2024-05-22"), ItinerarySummary = "A week exploring the temples and traditions of Kyoto.", TravelMode = "Flight", Rating = 4.6, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 15, UserID = 6, TripName = "Safari Expedition", Destination = "Kenya", StartDate = DateTime.Parse("2024-04-05"), EndDate = DateTime.Parse("2024-04-15"), ItinerarySummary = "Experience the wild side of Kenya on a safari adventure.", TravelMode = "Flight", Rating = 5.0, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 16, UserID = 7, TripName = "Historical Tour", Destination = "Rome", StartDate = DateTime.Parse("2024-03-10"), EndDate = DateTime.Parse("2024-03-14"), ItinerarySummary = "Discover the history of ancient Rome and visit the Colosseum.", TravelMode = "Flight", Rating = 4.3, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 17, UserID = 8, TripName = "Island Escape", Destination = "Bora Bora", StartDate = DateTime.Parse("2024-02-05"), EndDate = DateTime.Parse("2024-02-12"), ItinerarySummary = "Relax on the beautiful beaches of Bora Bora with crystal-clear waters.", TravelMode = "Flight", Rating = 4.9, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 18, UserID = 9, TripName = "Adventure in the Wild", Destination = "Canada", StartDate = DateTime.Parse("2024-01-10"), EndDate = DateTime.Parse("2024-01-17"), ItinerarySummary = "Go on a wild adventure in the Canadian wilderness with canoeing and hiking.", TravelMode = "Car", Rating = 4.2, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 19, UserID = 10, TripName = "Tropical Retreat", Destination = "Bali", StartDate = DateTime.Parse("2024-12-01"), EndDate = DateTime.Parse("2024-12-10"), ItinerarySummary = "Enjoy the tropical beauty of Bali and its serene beaches.", TravelMode = "Flight", Rating = 4.8, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 20, UserID = 12, TripName = "European Road Trip", Destination = "France, Italy, Germany", StartDate = DateTime.Parse("2024-06-25"), EndDate = DateTime.Parse("2024-07-05"), ItinerarySummary = "A road trip across Europe, visiting multiple countries in one go.", TravelMode = "Car", Rating = 4.5, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 21, UserID = 12, TripName = "Grand Asia Tour", Destination = "Thailand, Vietnam, Cambodia", StartDate = DateTime.Parse("2024-08-01"), EndDate = DateTime.Parse("2024-08-14"), ItinerarySummary = "Explore Southeast Asia’s cultural and natural beauty.", TravelMode = "Flight", Rating = 4.6, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 22, UserID = 13, TripName = "Trekking in Nepal", Destination = "Nepal", StartDate = DateTime.Parse("2024-05-01"), EndDate = DateTime.Parse("2024-05-10"), ItinerarySummary = "Trek through the Himalayas and visit Everest base camp.", TravelMode = "Flight", Rating = 4.7, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 23, UserID = 14, TripName = "Nature Expedition", Destination = "New Zealand", StartDate = DateTime.Parse("2024-09-10"), EndDate = DateTime.Parse("2024-09-17"), ItinerarySummary = "Experience the stunning landscapes of New Zealand.", TravelMode = "Flight", Rating = 4.9, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 24, UserID = 5, TripName = "Adventure in Patagonia", Destination = "Argentina, Chile", StartDate = DateTime.Parse("2024-10-01"), EndDate = DateTime.Parse("2024-10-10"), ItinerarySummary = "Explore the rugged beauty of Patagonia.", TravelMode = "Flight", Rating = 5.0, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 25, UserID = 6, TripName = "Caribbean Cruise", Destination = "Caribbean Islands", StartDate = DateTime.Parse("2024-07-15"), EndDate = DateTime.Parse("2024-07-25"), ItinerarySummary = "A luxurious cruise through the Caribbean islands.", TravelMode = "Cruise", Rating = 4.4, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 26, UserID = 7, TripName = "Tokyo Experience", Destination = "Japan", StartDate = DateTime.Parse("2024-04-01"), EndDate = DateTime.Parse("2024-04-07"), ItinerarySummary = "Experience the vibrant city life and culture of Tokyo.", TravelMode = "Flight", Rating = 4.6, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 27, UserID = 8, TripName = "Iceland Road Trip", Destination = "Iceland", StartDate = DateTime.Parse("2024-03-05"), EndDate = DateTime.Parse("2024-03-12"), ItinerarySummary = "Drive through the stunning landscapes of Iceland.", TravelMode = "Car", Rating = 4.7, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 28, UserID = 9, TripName = "Brazilian Carnival", Destination = "Brazil", StartDate = DateTime.Parse("2024-02-20"), EndDate = DateTime.Parse("2024-02-28"), ItinerarySummary = "Experience the vibrant Brazilian Carnival.", TravelMode = "Flight", Rating = 4.8, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 29, UserID = 10, TripName = "Egyptian Wonders", Destination = "Egypt", StartDate = DateTime.Parse("2024-11-05"), EndDate = DateTime.Parse("2024-11-12"), ItinerarySummary = "Visit the ancient wonders of Egypt including the pyramids and Sphinx.", TravelMode = "Flight", Rating = 4.9, NoOfTravellers = new Random().Next(1, 6) },
//    new EF.Tables.Trip { TripID = 30, UserID = 11, TripName = "South American Expedition", Destination = "Brazil, Argentina, Chile", StartDate = DateTime.Parse("2024-08-25"), EndDate = DateTime.Parse("2024-09-05"), ItinerarySummary = "Explore South America’s iconic cities and natural wonders.", TravelMode = "Flight", Rating = 4.6, NoOfTravellers = new Random().Next(1, 6) }
//};

//            // Add each trip to the database
//            foreach (var trip in trips)
//            {
//                context.Trips.Add(trip); // Add trip to the Trip table
//            }

//            // Save changes to the database
//            context.SaveChanges();




            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
