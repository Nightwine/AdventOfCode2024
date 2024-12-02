using AdventOfCode2024;

namespace Tests;

public class Day2Tests {
    [Test]
    public void Part1() {
        var subject = new Day2();
        
        Assert.That(subject.SafeReport(this.Input()), Is.EqualTo(2));
    }

    [Test]
    public void Part2() {
        var subject = new Day2();
        
        Assert.That(subject.SafeReport(this.Input()), Is.EqualTo(4));
    }

    private string Input() {
        return "7 6 4 2 1\n1 2 7 8 9\n9 7 6 2 1\n1 3 2 4 5\n8 6 4 4 1\n1 3 6 7 9";
    }
}