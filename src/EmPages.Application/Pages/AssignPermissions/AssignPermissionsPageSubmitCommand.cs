﻿using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using EmPages.Pages;

namespace EmPages.Application.Pages.AssignPermissions;

[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600", MessageId = "Elements should be documented", Justification = "Internal framework usage")]
public class AssignPermissionsPageSubmitCommand : IEmPageCommand
{
    public async Task<EmPageCommandResult> HandleAsync(EmPageRequest request)
    {
        return new EmPageCommandResult();
    }
}