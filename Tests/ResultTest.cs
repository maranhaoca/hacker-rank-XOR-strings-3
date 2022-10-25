using System;
using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        int n = 7;
        List<int> ar = new List<int>(){1, 2, 1, 2, 1, 3, 2};

        var expected = 2;

        var actual = Result.sockMerchant(n, ar);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        int n = 9;
        List<int> ar = new List<int>(){10, 20, 20, 10, 10, 30, 50, 10, 20};

        var expected = 3;

        var actual = Result.sockMerchant(n, ar);

        Assert.Equal(expected, actual);
    }
}