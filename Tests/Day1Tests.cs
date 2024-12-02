using AdventOfCode2024;

namespace Tests;

public class Day1Tests {
    [Test]
    public void Test1() {
        var subject = new Day1();
        
        Assert.That(subject.Result(this.Input()), Is.EqualTo(11));
    }

    [Test]
    public void Test2() {
        var subject = new Day1();
        
        Assert.That(subject.Result2(this.Input()), Is.EqualTo(31));
    }

    private string Input() {
        return "3   4\n4   3\n2   5\n1   3\n3   9\n3   3";
    }
}