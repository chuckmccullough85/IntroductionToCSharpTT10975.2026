In this lab, we will experiment with Linq queries on a database of movies.

| | | 
| --------- | --------------------------- |
| Exercise Folder | LinqAPI |
| Builds On | None |
| Time to complete | 30 minutes |

## Success Criteria
Your solution should:
- Query movies by actor name (case-insensitive search)
- Find oldest and most recent films for specified actors
- Identify movies with multiple specified actors
- Filter movies by rating (e.g., G-rated films)
- Project results to new data structures (title, year, cast)
- Order results by year and title
- Use FirstOrDefault and Last methods appropriately

## Where to find the solution
See [solutions/LinqAPI](../../solutions/LinqAPI)

---

## Overview
The project contains a file *MoviesJson.txt* that contains JSON encoded movie data.  
Each line in the file contains a movie title, genre, year, rating, and cast.
Review the file *MovieDb.cs*.  This class deserializes the data into a list of *Movie* objects.
> Note - the properties of *MoviesJson.txt* are set to copy the file to 
the output folder so that it is in the same directory as the application .exe.

## Lab
1. First, unzip the [starter project](Starter.zip)
1. Add the project to your existing solution (right click on the solution and choose *Add/Existing Project*)

In the top-level statements (*Program.cs*) experiment with queries

- How many movies did your favorite movie star appear in?
- What is the oldest movie with your star?
- What is the most recent?
- Did your favorite star appear in any movies with another favorite?
- Create a new list of just G rated movies with just the title, year, and first cast member
- etc...

---

*If you need a hint, see some code below:*

```c#

using LinqApi;

Console.WriteLine("Welcom to the Movie Database");

var mdb = new MovieDb();
var m = mdb.Movies.Where(m => m.Cast.Contains("Anthony Hopkins"));
Console.WriteLine(m.First().Title);
foreach (var c in m.First().Cast)
    Console.WriteLine($"\t{c}");

m = mdb.Movies.Where(m => m.Cast.Contains("Anthony Hopkins")).OrderBy(m => m.Year);
Console.WriteLine($"First movie in {m.First().Year} was {m.First().Title} starring:");
foreach(var c in m.First().Cast) Console.WriteLine($"\t{c}");

Console.WriteLine($"Last movie in {m.Last().Year} was {m.Last().Title} starring:");
foreach (var c in m.Last().Cast) Console.WriteLine($"\t{c}");

var jnj = mdb.Movies
    .Where(m => m.Cast.Contains("John Wayne") && m.Cast.Contains("James Stewart"))
    .OrderBy(m => m.Year)
    .Select(m => (m.Year, m.Title));
Console.WriteLine("Movies with Stewart & Wayne");
foreach (var t in jnj) Console.WriteLine($"{t.Year} {t.Title}");

Console.WriteLine("G movies");
var gmov = mdb.Movies.Where (m=>m.Rated == "G")
    .OrderBy(m=>(m.Year, m.Title))
    .Select(m=> (m.Year, m.Title, star: m.Cast.FirstOrDefault()));
foreach(var t in gmov) Console.WriteLine($"{t.Year} {t.Title} \t starring {t.star}");
   
```


