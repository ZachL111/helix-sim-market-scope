using HelixSimMarketScope;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(70, 38, 22, 82);
        if (DomainReviewLens.Score(item) != 194) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
