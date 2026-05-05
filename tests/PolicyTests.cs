using HelixSimMarketScope;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(54, 100, 23, 25, 9);
        if (Policy.Score(signalcase_1) != 116) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(73, 85, 20, 10, 6);
        if (Policy.Score(signalcase_2) != 187) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "accept") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(83, 71, 22, 9, 6);
        if (Policy.Score(signalcase_3) != 193) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "accept") throw new Exception("decision mismatch");
    }
}
