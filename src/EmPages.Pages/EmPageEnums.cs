namespace EmPages.Pages;
#pragma warning disable SA1602

/// <summary>
/// Page action type.
/// </summary>
public enum PageActionType
{
    /// <summary>
    /// Action is going to redirect user to another page/URL.
    /// </summary>
    Redirection = 1,

    /// <summary>
    /// Action is going to executes a command.
    /// </summary>
    Command = 2,
}

/// <summary>
/// Type of all different HTML multi choice elements.
/// </summary>
public enum MultiChoiceType
{
    Select = 1,
    CheckboxGroup = 2,
    RadioGroup = 3,
}

/// <summary>
/// Type of the component supported by the framework.
/// </summary>
public enum ComponentType
{
    Renderer = 1,
    Mutator = 2,
}

/// <summary>
/// Group of the wrapped type.
/// </summary>
public enum TypeGroup
{
    Texts = 1,
    Numbers = 2,
    Booleans = 3,
    DateTimes = 4,
    Enumerations = 5,
    Arrays = 6,
}

#pragma warning restore SA1602