using System;
using NUnit.Framework;
using CinemaApp;

namespace cinemaFunctionsTest;

public class Tests
{
    TicketPriceController ticketPriceController = new TicketPriceController();
    [SetUp]
    public void Setup()
    {
    }

    // Test the AdultBefore5 function
    [TestCase(0, "Adult", "Monday", 4, -1)]
    [TestCase(1, "Adult", "Monday", 4, 15)]
    [TestCase(2, "Adult", "Monday", 4, 30)]
    [TestCase(1, "Child", "Monday", 4, -1)]
    [TestCase(1, "Adult", "Tuesday", 4, -1)]
    [TestCase(1, "Adult", "Monday", 6, -1)]
    public void TestAdultBefore5(int quantity, string person, string day, decimal time, decimal expected)
    {
        decimal actual = ticketPriceController.AdultBefore5(quantity, person, day, time);
        Assert.AreEqual(expected, actual);
    }

    // Test the AdultAfter5 function
    [TestCase(0, "Adult", "Monday", 6, -1)]
    [TestCase(1, "Adult", "Monday", 6, 18)]
    [TestCase(2, "Adult", "Monday", 6, 36)]
    [TestCase(1, "Child", "Monday", 6, -1)]
    [TestCase(1, "Adult", "Tuesday", 6, -1)]
    [TestCase(1, "Adult", "Monday", 4, -1)]
    public void TestAdultAfter5(int quantity, string person, string day, decimal time, decimal expected)
    {
        decimal actual = ticketPriceController.AdultAfter5(quantity, person, day, time);
        Assert.AreEqual(expected, actual);
    }

    // Test the AdultTuesday function
    [TestCase(1, "Adult", "Monday", -1)]
    [TestCase(1, "Adult", "Tuesday", 14)]
    [TestCase(2, "Adult", "Tuesday", 28)]
    [TestCase(1, "Child", "Tuesday", -1)]
    [TestCase(1, "Adult", "Monday", -1)]
    public void TestAdultTuesday(int quantity, string person, string day, decimal expected)
    {
        decimal actual = ticketPriceController.AdultTuesday(quantity, person, day);
        Assert.AreEqual(expected, actual);
    }

    // Test the ChildUnder16 function
    [TestCase(0, "Child", -1)]
    [TestCase(1, "Child", 12)]
    [TestCase(2, "Child", 24)]
    [TestCase(1, "Adult", -1)]
    public void TestChildUnder16(int quantity, string person, decimal expected)
    {
        decimal actual = ticketPriceController.ChildUnder16(quantity, person);
        Assert.AreEqual(expected, actual);
    }

    // Test the Senior function
    [TestCase(0, "Senior", -1)]
    [TestCase(1, "Senior", 12)]
    [TestCase(2, "Senior", 24)]
    [TestCase(1, "Adult", -1)]
    public void TestSenior(int quantity, string person, decimal expected)
    {
        decimal actual = ticketPriceController.Senior(quantity, person);
        Assert.AreEqual(expected, actual);
    }

    // Test the Student function
    [TestCase(0, "Student", -1)]
    [TestCase(1, "Student", 12)]
    [TestCase(2, "Student", 24)]
    [TestCase(1, "Adult", -1)]
    public void TestStudent(int quantity, string person, decimal expected)
    {
        decimal actual = ticketPriceController.Student(quantity, person);
        Assert.AreEqual(expected, actual);
    }

    // Test the FamilyPass function
    [TestCase(1, 2, 2, 49)]
    [TestCase(1, 1, 1, -1)]
    [TestCase(1, 3, 2, -1)]
    [TestCase(1, 3, 1, 49)]
    public void TestFamilyPass(int quantity_ticket, int quantity_child, int quantity_adult, decimal expected)
    {
        decimal actual = ticketPriceController.FamilyPass(quantity_ticket, quantity_child, quantity_adult);
        Assert.AreEqual(expected, actual);
    }

    // Test the ChickFlickThursday function
    [TestCase(1, "Adult", "Monday", -1)]
    [TestCase(1, "Adult", "Thursday", 14)]
    [TestCase(2, "Adult", "Thursday", 28)]
    [TestCase(1, "Child", "Thursday", -1)]
    public void TestChickFlickThursday(int quantity, string person, string day, decimal expected)
    {
        decimal actual = ticketPriceController.ChickFlickThursday(quantity, person, day);
        Assert.AreEqual(expected, actual);
    }

    // Test the Kids_Careers function
    [TestCase(1, "Adult", "Monday", false, -1)]
    [TestCase(1, "Adult", "Wednesday", true, -1)]
    [TestCase(1, "Child", "Wednesday", true, 12)]
    [TestCase(2, "Child", "Wednesday", true, 24)]
    public void TestKidsCareers(int quantity, string person, string day, bool isHoliday, decimal expected)
    {
        decimal actual = ticketPriceController.KidsCareers(quantity, person, day, isHoliday);
        Assert.AreEqual(expected, actual);
    }
}
