using System;
using System.Linq.Expressions;
using Microsoft.Extensions.DependencyInjection;

namespace EmPages.Pages.Pages.Form;

/// <summary>
/// Abstract implementation of page for form presentation.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public abstract class EmFormPage<TModel> : EmPage<TModel, EmFormViewContext<TModel>, EmFormPageResult>, IEmFormPage
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmFormPage{TModel}"/> class.
    /// </summary>
    /// <param name="options"></param>
    protected EmFormPage(IEmPagesOptions options)
        : base(options)
    {
        this.ViewContext.ConfigureAll(options);
    }

    /// <inheritdoc/>
    public string SubmitCommandName { get; private set; }

    /// <inheritdoc/>
    public override void ValidatePageSetup()
    {
        if (string.IsNullOrEmpty(this.SubmitCommandName))
        {
            throw new EmSetupException("Form pages must have a submit command");
        }
    }

    /// <summary>
    /// Configure model property to form field.
    /// </summary>
    /// <param name="property"></param>
    /// <param name="itemAction"></param>
    /// <returns></returns>
    protected EmFormPage<TModel> ConfigureInput(
        Expression<Func<TModel, object>> property,
        Action<EmFormViewItem> itemAction)
    {
        this.ViewContext.Configure(property, itemAction);
        return this;
    }

    /// <summary>
    /// Sets the form submit command.
    /// </summary>
    /// <typeparam name="TCommand">Type of the submit command.</typeparam>
    protected void SetSubmitCommand<TCommand>()
        where TCommand : class, IEmPageCommand, new()
    {
        if (typeof(TCommand).Namespace != this.GetType().Namespace)
        {
            throw new EmSetupException("Page command must be at the same namespace as the page");
        }

        this.SubmitCommandName = typeof(TCommand).Name;
    }
}