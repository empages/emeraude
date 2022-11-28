using System;
using System.Text;

namespace EmPages.Pages.Tests;

public class TestPageModel : IEmPageModel
{
    public string Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public bool Active { get; set; }

    public StringBuilder Builder { protected get; set; }
    
    private Version Version { get; set; }

    public string GetFullName() => $"{this.FirstName} {this.LastName}";
}