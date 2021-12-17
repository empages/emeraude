using System;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Models;

namespace Emeraude.Tests.Application.Fakes;

public class FakeEmPageModel : IEmPageModel
{
    public string Id { get; set; }

    public string String { get; set; }

    public double Double { get; set; }

    public int Integer { get; set; }

    public DayOfWeek Enum { get; set; }

    public DateModel Date { get; set; }

    public object Object { get; set; }
}