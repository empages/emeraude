﻿using System.Threading;
using System.Threading.Tasks;
using Emeraude.Essentials.Models;
using Emeraude.Infrastructure.Localization.Persistence;
using Emeraude.Infrastructure.Localization.Persistence.Entities;
using MediatR;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.CreateKeyWithValues;

/// <summary>
/// Command which create translation key into localization context.
/// </summary>
public class CreateKeyWithValuesCommand : NewKeyWithValuesRequest, IRequest<MutationResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateKeyWithValuesCommand"/> class.
    /// </summary>
    /// <param name="request"></param>
    public CreateKeyWithValuesCommand(NewKeyWithValuesRequest request)
    {
        this.Key = request.Key;
        this.Values = request.Values;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateKeyWithValuesCommand"/> class.
    /// </summary>
    public CreateKeyWithValuesCommand()
    {
    }

    /// <summary>
    /// Create key with values command handler.
    /// </summary>
    public class CreateKeyWithValuesCommandHandler : IRequestHandler<CreateKeyWithValuesCommand, MutationResult>
    {
        private readonly ILocalizationContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeyWithValuesCommandHandler"/> class.
        /// </summary>
        /// <param name="context"></param>
        public CreateKeyWithValuesCommandHandler(ILocalizationContext context)
        {
            this.context = context;
        }

        /// <inheritdoc/>
        public async Task<MutationResult> Handle(CreateKeyWithValuesCommand request, CancellationToken cancellationToken)
        {
            var key = new TranslationKey
            {
                Key = request.Key,
            };

            foreach (var value in request.Values)
            {
                key.Translations.Add(new TranslationValue
                {
                    LanguageId = value.LanguageId,
                    Value = value.Value,
                    NormalizedValue = value.Value?.Trim().ToUpperInvariant() ?? string.Empty,
                });
            }

            this.context.Keys.Add(key);

            await this.context.SaveChangesAsync(cancellationToken);

            return new MutationResult(key.Id.ToString());
        }
    }
}