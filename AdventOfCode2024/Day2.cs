namespace AdventOfCode2024;

public class Day2 {
    public int SafeReport(string input) {
        var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        
        var safeCount = 0;

        foreach (var line in lines) {
            var lineInts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                               .Select(int.Parse)
                               .ToList();

            if (Safe(lineInts, lineInts[0] < lineInts[1])) {
                safeCount++;
            }
        }

        return safeCount;
    }

    private static bool Safe(List<int> input, bool increase) {
        while (true) {
            if (input.Count < 2) return true;

            var dif = increase ? input[1] - input[0] : input[0] - input[1];

            if (dif is <= 0 or >= 4) 
                return false;
            
            input = input.TakeLast(input.Count - 1).ToList();
        }
    }
}