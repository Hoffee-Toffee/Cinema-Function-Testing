using System;

namespace CinemaApp;

public class TicketPriceController
{

    public decimal AdultBefore5(int pr_quantity, string pr_person, string pr_day, decimal pr_time)
    {
        decimal ticket_price = 15M;
        decimal result = -1;

        if (pr_person.ToLower() != "adult" || pr_day.ToLower() == "tuesday" || pr_quantity < 1 || pr_time >= 5)
        {
            return result;
        }
        else
        {
            result = (ticket_price * pr_quantity);
            return result;
        }
    }


    public decimal AdultAfter5(int pr_quantity, string pr_person, string pr_day, decimal pr_time)
    {
        decimal ticket_price = 18M;
        decimal result = -1;

        if (pr_person.ToLower() != "adult" || pr_day.ToLower() == "tuesday" || pr_quantity < 1 || pr_time < 5)
        {
            return result;
        }
        else
        {
            result = (ticket_price * pr_quantity);
            return result;
        }
    }


    public decimal AdultTuesday(int pr_quantity, string pr_person, string pr_day)
    {
        decimal ticket_price = 14.00M;
        decimal result = -1;

        if (pr_person.ToLower() == "adult" && pr_day.ToLower() == "tuesday" && pr_quantity >= 1)
        {
            result = (ticket_price * pr_quantity);
            return result;
        }
        return result;
    }


    public decimal ChildUnder16(int pr_quantity, string pr_person)
    {
        decimal ticket_price = 12.00M;
        decimal result = -1;

        if (pr_person.ToLower() == "child" && pr_quantity >= 1)
        {
            result = (ticket_price * pr_quantity);
            return result;
        }
        return result;
    }


    public decimal Senior(int pr_quantity, string pr_person)
    {
        decimal ticket_price = 12.50M;
        decimal result = -1;

        if (pr_person.ToLower() == "senior" && pr_quantity >= 1)
        {
            result = (ticket_price * pr_quantity);
            return result;
        }
        return result;
    }


    public decimal Student(int pr_quantity, string pr_person)
    {
        decimal ticket_price = 12M;
        decimal result = -1;

        if (pr_person.ToLower() == "student" && pr_quantity >= 1)
        {
            result = (ticket_price * pr_quantity);
            return result;
        }
        return result;
    }


    public decimal FamilyPass(int pr_quantity_ticket, int pr_quantity_child, int pr_quantity_adult)
    {
        decimal ticket_price = 49M;
        decimal result = -1;

        if (pr_quantity_ticket >= 1 && pr_quantity_adult == 2 && pr_quantity_child == 2 ||
            pr_quantity_ticket >= 1 && pr_quantity_adult == 1 && pr_quantity_child == 3)
        {
            result = (ticket_price * pr_quantity_ticket);
            return result;
        }
        return result;
    }


    public decimal ChickFlickThursday(int pr_quantity, string pr_person, string pr_day)
    {
        decimal ticket_price = 14M;
        decimal result = -1;

        if (pr_person.ToLower() == "adult" && pr_day.ToLower() == "thursday" && pr_quantity >= 1)
        {
            result = (ticket_price * pr_quantity);
            return result;
        }
        return result;
    }


    public decimal KidsCareers(int pr_quantity, string person, string pr_day, bool pr_holiday)
    {
        decimal ticket_price = 12M;
        decimal result = -1;

        if (pr_quantity >= 1 && pr_day.ToLower() == "wednesday" && pr_holiday == false && person.ToLower() == "child")
        {
            result = (ticket_price * pr_quantity);
        }
        return result;
    }

}