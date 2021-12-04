using System;

namespace Emeraude.Essentials.Models;

/// <summary>
/// Result of mutation operation (create, modify, delete) that returns id of the mutated entity.
/// </summary>
public class MutationResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MutationResult"/> class.
    /// </summary>
    /// <param name="mutatedEntityId"></param>
    public MutationResult(string mutatedEntityId)
    {
        this.MutatedEntityId = mutatedEntityId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MutationResult"/> class.
    /// </summary>
    /// <param name="mutatedEntityId"></param>
    public MutationResult(int mutatedEntityId)
    {
        this.MutatedEntityId = mutatedEntityId.ToString();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MutationResult"/> class.
    /// </summary>
    /// <param name="mutatedEntityId"></param>
    public MutationResult(long mutatedEntityId)
    {
        this.MutatedEntityId = mutatedEntityId.ToString();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MutationResult"/> class.
    /// </summary>
    /// <param name="mutatedEntityId"></param>
    public MutationResult(Guid mutatedEntityId)
    {
        this.MutatedEntityId = mutatedEntityId.ToString();
    }

    /// <summary>
    /// Mutated entity id as string.
    /// </summary>
    public string MutatedEntityId { get; set; }

    /// <summary>
    /// Flag indicating whether if the operation succeeded or not.
    /// </summary>
    public bool Succeeded => !string.IsNullOrEmpty(this.MutatedEntityId);
}