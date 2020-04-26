using BlazorSchulungApril.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BlazorSchulungApril.Pages
{
    public class TitelRender:ComponentBase
    {
       [Inject] public PageTitelVM vm { get; set; }


   

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "title");
            builder.AddContent(1, vm.Titel);
            builder.CloseElement();

        }

        protected override async Task OnInitializedAsync()
        {
            vm.UpdateUI += (_, __) => InvokeAsync(StateHasChanged);

        }

    }
}
