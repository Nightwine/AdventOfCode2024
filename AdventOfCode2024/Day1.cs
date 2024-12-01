namespace AdventOfCode2024;

public class Day1 {

    public int Result(string input) {
        var lines = input.Split(Environment.NewLine);
        // build lists
        var left = new List<int>();
        var right = new List<int>();

        foreach (var line in lines) {
            var elements = line.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            
            left.Add(int.Parse(elements[0]));
            right.Add(int.Parse(elements[1]));
        }
        
        left.Sort();
        right.Sort();

        //reverse
        return left.Select((t, i) => Math.Abs(t - right[i])).Sum();
    }
    
    public int Result2(string input) {
        var lines = input.Split(Environment.NewLine);
        // build lists
        var left = new List<int>();
        var right = new Dictionary<int, int>();

        foreach (var line in lines) {
            var elements = line.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            
            left.Add(int.Parse(elements[0]));

            if (!right.TryAdd(int.Parse(elements[1]), 1)) {
                right[int.Parse(elements[1])]++;
            }
        }

        var score = 0;

        foreach (var entry in left) {
            if (right.TryGetValue(entry, out int rightCount)) {
                score += entry * rightCount;
            }
        }
        
        return score;
    }
    
}