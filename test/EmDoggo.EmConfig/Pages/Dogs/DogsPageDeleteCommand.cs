﻿using System.Threading.Tasks;
using EmPages.Pages;

namespace EmDoggo.EmConfig.Pages.Dogs;

public class DogsPageDeleteCommand : IEmPageCommand
{
    public async Task<EmPageCommandResult> HandleAsync(EmPageRequest request)
    {
        return new EmPageCommandResult();
    }
}