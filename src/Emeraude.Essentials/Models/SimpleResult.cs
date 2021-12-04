namespace Emeraude.Essentials.Models;

/// <summary>
/// Implementation of result that contains a success status.
/// </summary>
public class SimpleResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SimpleResult"/> class.
    /// </summary>
    /// <param name="succeeded"></param>
    public SimpleResult(bool succeeded = false)
    {
        this.Succeeded = succeeded;
    }

    /// <summary>
    /// Predefined successful result.
    /// </summary>
    public static SimpleResult SuccessfulResult => new SimpleResult(true);

    /// <summary>
    /// Predefined unsuccessful result.
    /// </summary>
    public static SimpleResult UnsuccessfulResult => new SimpleResult(false);

    /// <summary>
    /// Flag indicating whether if the operation succeeded or not.
    /// </summary>
    public bool Succeeded { get; protected set; }
}