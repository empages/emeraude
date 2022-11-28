using System;
using System.Collections.Generic;
using EmPages.Pages;

namespace EmDoggo.EmConfig.Pages.TestForm;

public class TestFormPageModel : IEmPageModel
{
    public string Id { get; set; }

    public DayOfWeek EnumSelect { get; set; }

    public DayOfWeek? NullableEnumSelect { get; set; }

    public DayOfWeek EnumRadio { get; set; }
    
    public DayOfWeek? NullableEnumRadio { get; set; }

    public IEnumerable<DayOfWeek> EnumEnumerable { get; set; }
}