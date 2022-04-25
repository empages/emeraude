namespace Emeraude.Pages.Tests;

public class TestPageModel : IEmPageModel
{
    public string Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public bool Active { get; set; }
}