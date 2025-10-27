using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

class Avengers
{
    public string Name { get; set; }
    public string[] Waepon { get; set; }
    public int CategoryId { get; set; }
}

class Category
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
}

class Marvel
{
    public string Name { get; set; }
}
class MarvelPsychic : Marvel
{
    public string HeroType { get; set; }
}

public class LinqExample : MonoBehaviour
{
    List<Avengers> alist = new List<Avengers>
    {
        new Avengers {Name = "Iron Man",
        Waepon=new string[]{"Mk.01","Mk.44","Mk.85" } },
        new Avengers {Name = "Thor",
        Waepon=new string[]{"Mjolnir", "Storm Breaker"}},
        new Avengers {Name="Captain America",
        Waepon=new string[]{"Mjolnir", "Shield"}},
    };

    List<Avengers> alist2 = new List<Avengers>
    {
        new Avengers { Name = "Iron Man", CategoryId = 0},
        new Avengers { Name = "Captain America", CategoryId = 0},
        new Avengers { Name = "Thor", CategoryId = 1},
        new Avengers { Name = "Loki", CategoryId = 1},
    };
    List<Category> categories = new List<Category>
    {
        new Category { Id = 0, CategoryName = "Human"},
        new Category { Id = 1, CategoryName = "Not Human"}
    };
    
    void Start()
    {
        string[] avengers = { "Iron Man", "Captain America",
            "Thor", "Hulk", "Black Panther", "Spider Man"};

        ///////////////// OrderBy
        IEnumerable<string> q = from hero in avengers
                                orderby hero.Length
                                select hero;
        //DebugLog(q);

        ////////////////// OrderByDescending
        q = from hero in avengers
            orderby hero.Substring(0, 1) descending
            select hero;
        //DebugLog(q);
        q = from hero in avengers
            orderby hero.Length, hero.Substring(0, 1)
            select hero;
        //DebugLog(q);
        q = from hero in avengers
            orderby hero.Length, hero.Substring(0, 1) descending
            select hero;
        //DebugLog(q);

        /////////////////// Distinct
        string[] avengers1 = {"Iron Man", "Iron Man",
            "Captain America", "Thor"};
        q = from hero in avengers1.Distinct()
            select hero;
        //DebugLog(q);

        /////////////////////// Except
        string[] avengers21 = { "Iron Man", "Captain America", "Thor" };
        string[] avengers22 = { "Iron Man", "Hulk", "Captain America" };
        q = from hero in avengers21.Except(avengers22)
            select hero;
        //DebugLog(q);

        //////////////////////// Intersect
        q = from hero in avengers21.Intersect(avengers22)
            select hero;
        //DebugLog(q);

        ////////////////////////// Union
        q = from hero in avengers21.Union(avengers22)
            select hero;
        //DebugLog(q);

        ////////////////////////// Where
        q = from hero in avengers
            where hero.Length > 4
            select hero;
        //DebugLog(q); 

        ///////////////////////// All
        q = from hero in alist
            where hero.Waepon.All(item => item.Length == 5)
            select hero.Name;
        //DebugLog(q);

        ///////////////////////// Any
        q = from hero in alist
            where hero.Waepon.Any(item => item.StartsWith("M"))
            select hero.Name;
        //DebugLog(q);

        ////////////////////////// Contains
        q = from hero in alist
            where hero.Waepon.Contains("Mjolnir")
            select hero.Name;
        //DebugLog(q);

        ////////////////////////// Select
        q = from hero in avengers
            select hero.Substring(0, 1);
        //DebugLog(q);

        ////////////////////////// Join
        var avengerGroups = from category in categories
                            join avenger in alist2 on category.Id
                            equals avenger.CategoryId into avengerGroup
                            select avengerGroup;
        /*
        foreach (var avengerGroup in avengerGroups)
        {
            Debug.Log("Group");
            foreach (Avengers avenger in avengerGroup)
            {
                Debug.Log($"{avenger.Name,20}");
            }
        }
        */

        /////////////////////////// Group
        List<int> numbers = new List<int>() { 3, 2, 4, 66, 13 };
        IEnumerable<IGrouping<int, int>> q2 = from number in numbers
                                              group number by number % 2;
        /*
        foreach (var group in q2)
        {
            Debug.Log(group.Key == 0 ? "Even:" : "Odd:");
            foreach (int i in group)
            {
                Debug.Log(i);
            }
        }
        */

        ///////////////////////////// cast
        Marvel[] marvels = new Marvel[]
        {
            new MarvelPsychic { Name = "Iron Man", HeroType = "Suit Hero"},
            new MarvelPsychic { Name = "Spider Man", HeroType = "Suit Hero"},
            new MarvelPsychic { Name = "Thor", HeroType = "God"},
            new MarvelPsychic { Name = "Thanos", HeroType = "Villain"},
        };
        var q3 = from MarvelPsychic marvelPsychic in marvels
                 where marvelPsychic.HeroType == "Suit Hero"
                 select marvelPsychic; 
        foreach (Marvel marvel in q3)
        {
            Debug.Log(marvel.Name);
        }
    }

    void DebugLog(IEnumerable<string> query)
    {
        Debug.Log("======== start ========");
        foreach (var item in query)
        {
            Debug.Log(item);
        }
    }
}
