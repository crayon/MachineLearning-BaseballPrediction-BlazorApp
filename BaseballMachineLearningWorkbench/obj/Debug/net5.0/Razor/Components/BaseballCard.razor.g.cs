#pragma checksum "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\Components\BaseballCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64aba56da7350cf122616eb8de564df32944e8a7"
// <auto-generated/>
#pragma warning disable 1591
namespace BaseballMachineLearningWorkbench.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using BaseballMachineLearningWorkbench;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using BaseballMachineLearningWorkbench.MachineLearning;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using BaseballMachineLearningWorkbench.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using BaseballMachineLearningWorkbench.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using BaseballMachineLearningWorkbench.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using Microsoft.Extensions.ML;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    public partial class BaseballCard : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "containerFadeIn");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card" + " bg-c-" + (
#nullable restore
#line 4 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\Components\BaseballCard.razor"
                            (Prediction is null) ? "blue" : GetCardColor(this.UseMachineLearningModel, Prediction.Probability, (int) this.BaseBallBatter.HR)

#line default
#line hidden
#nullable disable
            ) + "  order-card");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-block");
            __builder.OpenElement(6, "h6");
            __builder.AddAttribute(7, "class", "text-right");
            __builder.AddContent(8, "Hall of Fame ");
            __builder.OpenElement(9, "b");
#nullable restore
#line 6 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\Components\BaseballCard.razor"
__builder.AddContent(10, MachineLearning.Helpers.GetPredictionLabel(this.MLModelPredictionType, UseMachineLearningModel));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddContent(11, " - ");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "span-probability");
            __builder.OpenElement(14, "b");
#nullable restore
#line 6 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\Components\BaseballCard.razor"
__builder.AddContent(15, this.GetPredictionValue(this.UseMachineLearningModel));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "h6");
            __builder.AddAttribute(18, "class", "text-right");
            __builder.OpenElement(19, "span");
            __builder.OpenElement(20, "b");
#nullable restore
#line 7 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\Components\BaseballCard.razor"
__builder.AddContent(21, BaseBallBatter.FullPlayerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "m-b-0");
            __builder.AddContent(25, "Seasons Played");
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "class", "f-right");
#nullable restore
#line 8 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\Components\BaseballCard.razor"
__builder.AddContent(28, BaseBallBatter.YearsPlayed);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "m-b-0");
            __builder.AddContent(32, "Total Bases");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "class", "f-right");
#nullable restore
#line 9 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\Components\BaseballCard.razor"
__builder.AddContent(35, BaseBallBatter.TB);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "m-b-0");
            __builder.AddContent(39, "HR");
            __builder.OpenElement(40, "span");
            __builder.AddAttribute(41, "class", "f-right");
#nullable restore
#line 10 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\Components\BaseballCard.razor"
__builder.AddContent(42, BaseBallBatter.HR);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "m-b-0");
            __builder.AddContent(46, "Total Player Awards");
            __builder.OpenElement(47, "span");
            __builder.AddAttribute(48, "class", "f-right");
#nullable restore
#line 11 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\Components\BaseballCard.razor"
__builder.AddContent(49, BaseBallBatter.TotalPlayerAwards);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.AddMarkupContent(51, "<div class=\"m-b-0\">...<span class=\"f-right\"></span></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Bart-MLB\MachineLearning-BaseballPrediction-BlazorApp\BaseballMachineLearningWorkbench\Components\BaseballCard.razor"
       

    /* Parameters */

    [Parameter]
    public MLModelPredictionType MLModelPredictionType { get; set; } = MachineLearning.MLModelPredictionType.InductedToHallOfFameGeneralizedAdditiveModel;

    [Parameter]
    public bool UseMachineLearningModel { get; set; } = true;

    [Parameter]
    public MLBBaseballBatter BaseBallBatter { get; set; }

    [Parameter]
    public MLBHOFPrediction Prediction { get; set; }

    // Used for setting the background color of the baseball card
    private string GetCardColor(bool useMachineLearningModel, float probability, int homeRuns)
    {
        string cardColor = "red";
        logger.LogInformation($"GetCardColor| UseMachineLearningModel: {useMachineLearningModel} Probability: {probability}");

        if (useMachineLearningModel)
        {
            if (probability >= 0.80)
            {
                cardColor = "green";
            }
            else if (probability >= 0.50)
            {
                cardColor = "lightgreen";
            }
            else if (probability >= 0.25)
            {
                cardColor = "yellow";
            }
        }
        else
        {
            if (homeRuns >= 500)
            {
                cardColor = "green";
            }
        }

        logger.LogInformation($"GetCardColor| CardColor: {cardColor}");
        return cardColor;
    }

    // Used for setting the prediction value
    private string GetPredictionValue(bool useMachineLearningModel)
    {
        if (Prediction is null)
        {
            return string.Empty;
        }

        string predictionLabel = string.Empty;

        if (useMachineLearningModel)
        {
            predictionLabel = String.Format("{0:P2}", Prediction.Probability);
        }
        else
        {
            predictionLabel = Prediction.Prediction.ToString();
        }

        logger.LogInformation($"GetPredictionValue| PredictionLabel: {predictionLabel}");
        return predictionLabel;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<BaseballCard> logger { get; set; }
    }
}
#pragma warning restore 1591
