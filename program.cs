using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

/* Do not touch any code in the Program class */
public class Program
{
    private static string _moviesJson = MoviesJsonProvider.GetMoviesJson();

    /* Do not change anything in Main() */
    public static void Main()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        Movie[] movies = JsonSerializer.Deserialize<Movie[]>(_moviesJson, options);

        Console.WriteLine("*********** EXERCISE 1 OUTPUT **********");
        Console.WriteLine(JsonSerializer.Serialize<Movie[]>(movies, new JsonSerializerOptions { WriteIndented = true }));
        Console.WriteLine();

        Console.WriteLine("*********** EXERCISE 2 OUTPUT **********");
        Console.WriteLine(Exercise2.GetResult(movies));
        Console.WriteLine();

        Console.WriteLine("*********** EXERCISE 3 OUTPUT **********");
        Console.WriteLine(Exercise3.GetResult(movies));
        Console.WriteLine();

        Console.WriteLine("*********** EXERCISE 4 OUTPUT **********");
        Console.WriteLine(Exercise4.GetResult(movies));
    }
}

/* --------------------- EXERCISE 1 --------------------- */

/* Fill out the following class to mirror the structure of the movie JSON for the JsonSerializer.Deserialize call in Main() */
/* Clicking Run should show the list of movies in the output window */

public class Movie
{

}


/* --------------------- EXERCISE 2 --------------------- */

/* Return only movies from 2014 (there are 6), see example output below */

public static class Exercise2
{
    public static string GetResult(Movie[] movies)
    {
        return "";
    }
}

/*  Example Output 

[
{
"Title": "The Giver",
"Year": 2014,
"Cast": [
    "Jeff Bridges",
    "Meryl Streep",
    "Brenton Thwaites",
    "Katie Holmes"
],
"Genres": [
    "Science Fiction"
]
},
{
"Title": "Life After Beth",
"Year": 2014,
"Cast": [
    "Aubrey Plaza",
    "Dane DeHaan",
    "Anna Kendrick",
    "Molly Shannon"
],
"Genres": [
    "Comedy"
]
},

...

{
"Title": "Dolphin Tale 2",
"Year": 2014,
"Cast": [
    "Harry Connick, Jr.",
    "Ashley Judd",
    "Nathan Gamble",
    "Kris Kristofferson",
    "Morgan Freeman"
],
"Genres": [
    "Drama"
]
}
]

*/


/* --------------------- EXERCISE 3 --------------------- */

/* Return movie titles and year for movies with Bruce Willis (there are 4), see example output below */

public static class Exercise3
{
    public static string GetResult(Movie[] movies)
    {
        return "";
    }
}

/* Example Output 

[
  {
    "Title": "Die Hard",
    "Year": 1988
  },
  {
    "Title": "Nobody\u0027s fool",
    "Year": 1994
  },
  {
    "Title": "Pulp Fiction",
    "Year": 1994
  },
  {
    "Title": "Looper",
    "Year": 2012
  }
]

*/


/* --------------------- EXERCISE 4 --------------------- */

/* Return actors and movie titles for actors who have been in more than 1 movie (there are 6), see example output below */

public static class Exercise4
{
    public static string GetResult(Movie[] movies)
    {
        return "";
    }
}

/* Example Output 

[
  {
    "Actor": "Bruce Willis",
    "Titles": [
      "Die Hard",
      "Nobody\u0027s fool",
      "Pulp Fiction",
      "Looper"
    ]
  },
  {
    "Actor": "George Clooney",
    "Titles": [
      "Fargo",
      "Gravity"
    ]
  },
     ...

  {
    "Actor": "Nicole Kidman",
    "Titles": [
      "Aquaman",
      "Destroyer"
    ]
  }
]

*/


/* --------------------- JSON PROVIDER --------------------- */

/* Do not modify code in the MoviesJsonProvider class */
public static class MoviesJsonProvider
{
    private static string _moviesJson =
@"[
  {
    ""title"": ""Dirty Dancing"",
    ""year"": 1987,
    ""cast"": [""Jennifer Grey"", ""Patrick Swayze"", ""Jerry Orbach"", ""Cynthia Rhodes""],
    ""genres"": [""Drama"", ""Music"", ""Romance""]
  },
  {
    ""title"": ""Die Hard"",
    ""year"": 1988,
    ""cast"": [
      ""Bruce Willis"",
      ""Bonnie Bedelia"",
      ""Reginald VelJohnson"",
      ""Paul Gleason"",
      ""William Atherton"",
      ""Hart Bochner""
    ],
    ""genres"": [""Action"", ""Thriller""]
  },
  {
    ""title"": ""Nobody's fool"",
    ""year"": 1994,
    ""cast"": [
      ""Paul Newman"",
      ""Jessica Tandy"",
      ""Bruce Willis"",
      ""Melanie Griffith"",
      ""Dylan Walsh""
    ],
    ""genres"": [""Comedy"", ""Drama""]
  },
  {
    ""title"": ""Pulp Fiction"",
    ""year"": 1994,
    ""cast"": [
      ""John Travolta"",
      ""Samuel L. Jackson"",
      ""Uma Thurman"",
      ""Bruce Willis"",
      ""Ving Rhames""
    ],
    ""genres"": [""Crime"", ""Drama""]
  },
  {
    ""title"": ""Empire Records"",
    ""year"": 1995,
    ""cast"": [
      ""Anthony LaPaglia"",
      ""Maxwell Caulfield"",
      ""Debi Mazar"",
      ""Liv Tyler"",
      ""Renee Zellweger"",
      ""Rory Cochrane""
    ],
    ""genres"": [""Comedy"", ""Drama"", ""Music""]
  },
  {
    ""title"": ""Fargo"",
    ""year"": 1996,
    ""cast"": [
      ""George Clooney"",
      ""John Turturro"",
      ""Tim Blake Nelson"",
      ""John Goodman"",
      ""Holly Hunter"",
      ""Chris Thomas King""
    ],
    ""genres"": [""Crime"", ""Drama"", ""Thriller""]
  },
  {
    ""title"": ""O Brother, Where Art Thou?"",
    ""year"": 2000,
    ""cast"": [
      ""William H. Macy"",
      ""Steve Buscemi"",
      ""Peter Stormare"",
      ""Kristin Rudrüd"",
      ""Harve Presnell""
    ],
    ""genres"": [""Crime"", ""Drama"", ""Thriller""]
  },
  {
    ""title"": ""The Cabin in the Woods"",
    ""year"": 2011,
    ""cast"": [
      ""Kristen Connolly"",
      ""Chris Hemsworth"",
      ""Anna Hutchison"",
      ""Fran Kranz"",
      ""Jesse Williams""
    ],
    ""genres"": [""Horror""]
  },
  {
    ""title"": ""Looper"",
    ""year"": 2012,
    ""cast"": [
      ""Joseph Gordon-Levitt"",
      ""Bruce Willis"",
      ""Emily Blunt"",
      ""Paul Dano"",
      ""Noah Segan""
    ],
    ""genres"": [""Action"", ""Crime"", ""Drama""]
  },
  {
    ""title"": ""Gravity"",
    ""year"": 2013,
    ""cast"": [
      ""Sandra Bullock"",
      ""George Clooney"",
      ""Ed Harris"",
      ""Orto Ignatiussen"",
      ""Phaldut Sharma""
    ],
    ""genres"": [""Drama"", ""Science Fiction"", ""Thriller""]
  },
  {
    ""title"": ""The Giver"",
    ""year"": 2014,
    ""cast"": [""Jeff Bridges"", ""Meryl Streep"", ""Brenton Thwaites"", ""Katie Holmes""],
    ""genres"": [""Science Fiction""]
  },
  {
    ""title"": ""Life After Beth"",
    ""year"": 2014,
    ""cast"": [""Aubrey Plaza"", ""Dane DeHaan"", ""Anna Kendrick"", ""Molly Shannon""],
    ""genres"": [""Comedy""]
  },
  {
    ""title"": ""The One I Love"",
    ""year"": 2014,
    ""cast"": [""Mark Duplass"", ""Ted Danson"", ""Elisabeth Moss""],
    ""genres"": [""Romance"", ""Comedy""]
  },
  {
    ""title"": ""If I Stay"",
    ""year"": 2014,
    ""cast"": [
      ""Chloë Grace Moretz"",
      ""Mireille Enos"",
      ""Jamie Blackley"",
      ""Joshua Leonard""
    ],
    ""genres"": [""Romance""]
  },
  {
    ""title"": ""Love Is Strange"",
    ""year"": 2014,
    ""cast"": [""John Lithgow"", ""Alfred Molina"", ""Marisa Tomei"", ""Charlie Tahan""],
    ""genres"": [""Drama""]
  },
  {
    ""title"": ""Dolphin Tale 2"",
    ""year"": 2014,
    ""cast"": [
      ""Harry Connick, Jr."",
      ""Ashley Judd"",
      ""Nathan Gamble"",
      ""Kris Kristofferson"",
      ""Morgan Freeman""
    ],
    ""genres"": [""Drama""]
  },
  {
    ""title"": ""The SpongeBob Movie: Sponge Out of Water"",
    ""year"": 2015,
    ""cast"": [""Antonio Banderas"", ""Tom Kenny"", ""Clancy Brown"", ""Rodger Bumpass""],
    ""genres"": [""Animated"", ""Adventure""]
  },
  {
    ""title"": ""The Voices"",
    ""year"": 2015,
    ""cast"": [""Ryan Reynolds"", ""Anna Kendrick"", ""Gemma Arterton"", ""Jacki Weaver""],
    ""genres"": [""Comedy""]
  },
  {
    ""title"": ""Accidental Love"",
    ""year"": 2015,
    ""cast"": [""Jessica Biel"", ""Catherine Keener"", ""James Marsden"", ""Tracy Morgan""],
    ""genres"": [""Comedy""]
  },
  {
    ""title"": ""Mary Poppins Returns"",
    ""year"": 2018,
    ""cast"": [
      ""Emily Blunt"",
      ""Lin-Manuel Miranda"",
      ""Ben Whishaw"",
      ""Emily Mortimer"",
      ""Julie Walters"",
      ""Colin Firth"",
      ""Meryl Streep"",
      ""Dick Van Dyke"",
      ""Angela Lansbury""
    ],
    ""genres"": [""Musical"", ""Fantasy""]
  },
  {
    ""title"": ""Aquaman"",
    ""year"": 2018,
    ""cast"": [
      ""Jason Momoa"",
      ""Amber Heard"",
      ""Willem Dafoe"",
      ""Patrick Wilson"",
      ""Dolph Lundgren"",
      ""Yahya Abdul-Mateen II"",
      ""Nicole Kidman""
    ],
    ""genres"": [""Superhero"", ""Action"", ""Adventure""]
  },
  {
    ""title"": ""Bumblebee"",
    ""year"": 2018,
    ""cast"": [
      ""Hailee Steinfeld"",
      ""John Cena"",
      ""Jorge Lendeborg Jr."",
      ""Jason Drucker"",
      ""Rachel Crow"",
      ""Pamela Adlon""
    ],
    ""genres"": [""Action"", ""Adventure"", ""Science Fiction""]
  },
  {
    ""title"": ""Welcome to Marwen"",
    ""year"": 2018,
    ""cast"": [
      ""Steve Carell"",
      ""Leslie Mann"",
      ""Diane Kruger"",
      ""Falk Hentschel"",
      ""Janelle Monáe"",
      ""Eiza Gonzalez"",
      ""Gwendoline Christie""
    ],
    ""genres"": [""Fantasy"", ""Drama""]
  },
  {
    ""title"": ""Holmes and Watson"",
    ""year"": 2018,
    ""cast"": [
      ""Will Ferrell"",
      ""John C. Reilly"",
      ""Rebecca Hall"",
      ""Ralph Fiennes"",
      ""Rob Brydon"",
      ""Kelly Macdonald"",
      ""Lauren Lapkus"",
      ""Hugh Laurie""
    ],
    ""genres"": [""Action"", ""Mystery"", ""Comedy""]
  },
  {
    ""title"": ""Destroyer"",
    ""year"": 2018,
    ""cast"": [
      ""Nicole Kidman"",
      ""Tatiana Maslany"",
      ""Sebastian Stan"",
      ""Toby Kebbell"",
      ""Scoot McNairy""
    ],
    ""genres"": [""Crime"", ""Thriller""]
  }
]";

    public static string GetMoviesJson()
    {
        return _moviesJson;
    }
}
