public class Solution {
    public int FindJudge(int N, int[][] trust) {
        //Creates a basic hashtable that will be used to represent a graph.
        Dictionary<int, List<int>> neighbors = new Dictionary<int, List<int>>();
        List<int> potentialJudges = new List<int>();
        //Generates a "trust graph" by adding each "trustee" member to the value of the dictionary at item "truster"
        for (var i = 0; i < trust.Length; i++)
        {
            if (neighbors.ContainsKey(trust[i][0]))
            {
                neighbors[trust[i][0]].Add(trust[i][1]);
            }
            else 
            {
                neighbors.Add(trust[i][0], new List<int> {trust[i][1]}); 
            }
        }
        
        //If any of the numbers from 1 to N do not have entries in the trust graph, they are potential judges.
        //At this point, the array of potentialJudges satisfies invariant 1.
        for(var i = 1; i <= N; i++)
        {
            if(neighbors.ContainsKey(i))
            {
                continue;
            }
            potentialJudges.Add(i);
        }
        
        //If there are more than one potential Judges, there is no judge as they have to be trusted by everyone else
        //Invariant 2 is violated and we return -1.
        if (potentialJudges.Count > 1)
        {
        return -1;
        }
        //Searches the graph for any neighbors that *don't* trust the potential judge.
        //If any neighbor *doesn't* trust the judge, invariant 2 is violated.
        foreach (var neighbor in neighbors)
        {
            for(var i = 0; i < potentialJudges.Count; i++)
            {
                //There is probably a more efficient way to establish if the neighbor is trusted.
                //Potentially two arrays.
                if(neighbor.Value.Contains(potentialJudges[i]))
                {
                 continue;   
                }
                else
                {
                    potentialJudges.Remove(potentialJudges[i]);
                }
            }
        }
        
        if(potentialJudges.Count != 0)
        {
            return potentialJudges[0];
        }
        else
        {
            //If we make it here we have failed.
            return -1;
        }
        
    }
}

//Valid solution to: https://leetcode.com/contest/weekly-contest-125/submissions/detail/210166449/
//Written by: Connor Matza
