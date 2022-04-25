namespace Emeraude.Pages;

/// <summary>
/// Page action type.
/// </summary>
public enum PageActionType
{
    Routing = 1,
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