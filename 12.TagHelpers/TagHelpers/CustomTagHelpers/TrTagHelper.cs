using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.CustomTagHelpers
{
    //1. Apply attribute to selected tags.
    //[HtmlTargetElement("tr", Attributes = "bg-color,text-color", ParentTag = "thead")]
    //[HtmlTargetElement("tr", Attributes = "bg-color,text-color", ParentTag = "tbody")]

    //2. applying to all tr tags inside tbody
    //[HtmlTargetElement("tr", ParentTag = "tbody")]

    //3. apply to all elements with the given Attributes
    [HtmlTargetElement("*", Attributes = "bg-color,text-color")]
    public class TrTagHelper : TagHelper
    {
        public string BgColor { get; set; } = "dark";
        public string TextColor { get; set; } = "white";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"bg-{BgColor} text-center text-{TextColor}");
        }

    }
}
