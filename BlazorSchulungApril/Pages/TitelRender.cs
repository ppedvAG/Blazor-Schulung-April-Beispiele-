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
        [Parameter]
        public string Titel { get; set; }
        public string Titel2 { get; set; }

        private string _titel2;

        public string Title2
        {
            get { return _titel2; }
            set { _titel2 = value;
                Titel = value;
            }
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "title");
            builder.AddContent(1, Titel);
            builder.CloseElement();

        }
    }
}
