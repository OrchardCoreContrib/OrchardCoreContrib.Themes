using System;
using System.Threading.Tasks;
using Fluid;
using Fluid.Values;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrchardCore.Liquid;

namespace OrchardCore.Themes.TheModernBusinessTheme
{
    public class TagBuilderFilter : ILiquidFilter
    {
        public ValueTask<FluidValue> ProcessAsync(FluidValue input, FilterArguments arguments, TemplateContext ctx)
        {
            if (input.ToObjectValue() is TagBuilder tagBuilder)
            {
                if (arguments.HasNamed("add_classes"))
                {
                    var classes = arguments["add_classes"].ToStringValue();
                    if (!string.IsNullOrEmpty(classes))
                    {
                        foreach (var cssClass in classes.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                        {
                            tagBuilder.AddCssClass(cssClass);
                        }
                    }
                }

                return new ValueTask<FluidValue>(input);
            }

            return new ValueTask<FluidValue>(NilValue.Instance);
        }
    }
}
