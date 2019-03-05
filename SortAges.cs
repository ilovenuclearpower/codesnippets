using System;
using System.Collections.Generic;

struct Person
{
    public int Age { get; set; }
}

class Solution
{
    static ReadOnlySpan<Person> SortByAge(Person[] input)
    {
        var output = new Person[input.Length];
        //Creates an array containing the number of people at every age.
        var ages = new int[150];
        for (int i = 0; i < input.Length; i++)
        {
            ages[input[i].Age] += 1;
        }
        
        
        // [ 5, 8, 18, 77, 77, 77, 52, 12, 8, 5 ]
        
        // [ 5, 5, 8, 8, 12, 18, 52, 77, 77, 77 ]
        
        // ages {
        // 5 = 2,
        // 8 = 2,
        // 12 = 1,
        // 18 = 1,
        // 52 = 1,
        // 77 = 3
        // }
        
        int counter = 0;
        Person personHeld = input[0];
        //Groups each age into a "bucket" by finding the start index of every age (startindex = previous startindex
        // + previous number of ages. As you iterate through, this determines the number of indices each age needs and their
        //relative location
        
        int[] startIndexes = new int[ages.Length];
        int offSetCounter = 0;
        for ( int i = 0; i < ages.Length; i++)
        {
            startIndexes[i] = offSetCounter;
            offSetCounter += ages[i];
        }
        
        //The meat of the algorithm, determines the location of the person by their age and the startindex and number
        // of ages table. Picks up the person at that location, then drops the held person in the same location.
        //Runtime O(n)
        while (counter < input.Length)
        {
            int ageOffSet = ages[personHeld.Age] -1;
            ages[personHeld.Age]--;
            Person tempPerson = input[startIndexes[personHeld.Age] + ageOffSet];
            input[startIndexes[personHeld.Age + ageOffSet]] = personHeld; 
            personHeld = tempPerson;
            counter++;
        }
        
        //Deals with the end of the loop edge case (we haven't dropped the last person yet)
        //This portion is not tested - if it doesn't compile comment it out.
        int endAgeOffSet = ages[personHeld.Age] -1;
        input[startIndexes[personHeld.Age + ageOffSet]] = personHeld;
        
        return new ReadOnlySpan<Person>(input);
    }
    
    //Driver function for testing.
    static void Main(string[] args)
    {
        var people = new List<Person> {
            new Person { Age = 15 },
            new Person { Age = 10 },
            new Person { Age = 20 },
            new Person { Age = 77 },
            new Person { Age = 102 },
            new Person { Age = 20 },
            new Person { Age = 50 },
            new Person { Age = 51 },
            new Person { Age = 0 },
            new Person { Age = 18 },
        };
        
        
        // (imagine people get populated here)
        
        var sortedPeople = SortByAge(people.ToArray());
        //Output function.
        foreach (Person p in sortedPeople)
        {
            Console.WriteLine(p.Age);
        }
    }
}
//Sorts an array of People by their age. Written by Connor Matza for a mock interview w/ Blizzard
//Written by Connor Alexander Matza for a mock interview with a Blizzard Senior
