using Algorithms;

List<Item> data = new()
{
    new Item { TimeLabel = "2017-T01", Amount = 112 },
    new Item { TimeLabel = "2017-T02", Amount = 189 },
    new Item { TimeLabel = "2017-T03", Amount = 172 },
    new Item { TimeLabel = "2017-T04", Amount = 85 },

    new Item { TimeLabel = "2018-T01", Amount = 123 },
    new Item { TimeLabel = "2018-T02", Amount = 201 },
    new Item { TimeLabel = "2018-T03", Amount = 182 },
    new Item { TimeLabel = "2018-T04", Amount = 103 },

    new Item { TimeLabel = "2019-T01", Amount = 132 },
    new Item { TimeLabel = "2019-T02", Amount = 198 },
    new Item { TimeLabel = "2019-T03", Amount = 185 },
    new Item { TimeLabel = "2019-T04", Amount = 112 },

    new Item { TimeLabel = "2020-T01", Amount = 130 },
    new Item { TimeLabel = "2020-T02", Amount = 220 },
    new Item { TimeLabel = "2020-T03", Amount = 190 },
    new Item { TimeLabel = "2020-T04", Amount = 109 },
};

MobileAverage mobileAverage = new () { SizeWindow = 4 };

var temp = mobileAverage.GetMovingAverage(data.Select(x => x.Amount).ToList());
var temp2 = mobileAverage.GetSeansonalCoefficients(data.Select(x => x.Amount).ToList());

Console.WriteLine();
