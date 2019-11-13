﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace DevIO.UI.Site.Extensions
{
    public class EmailTagHelper : TagHelper
    {
        public string EmmailDomain { get; set; } = "desenvolvedor.io";
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + EmmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + target);
            output.Content.SetContent(target);
        }
    }
}
