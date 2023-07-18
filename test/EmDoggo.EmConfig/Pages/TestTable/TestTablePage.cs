﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EmPages.Pages;
using EmPages.Pages.Pages.Table;

namespace EmDoggo.EmConfig.Pages.TestTable;

[EmNavigationItem(10, "Test Table", "flag-variant")]
[EmRoute("/test/table")]
public class TestTablePage : EmTablePage<TestTablePageModel>
{
    public override async Task SetupAsync()
    {
    }

    public override async Task<EmTablePageResult> FetchDataAsync(EmPageRequest request)
    {
        return new EmTablePageResult
        {
            Models = new List<TestTablePageModel>
            {
                new TestTablePageModel(),
                new TestTablePageModel()
            },
        };
    }
}