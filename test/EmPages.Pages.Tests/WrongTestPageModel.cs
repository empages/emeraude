using System;
using System.Text;

namespace EmPages.Pages.Tests;

public class WrongTestPageModel : IEmPageModel
{
    public string Id { get; set; }

    public string Name { get; set; }

    public DayOfWeek Day { get; set; }

    public StringBuilder StringBuilder { get; set; }
}