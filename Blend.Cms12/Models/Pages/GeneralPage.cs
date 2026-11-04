using Microsoft.AspNetCore.Html;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Blend.Cms12.Models.Pages
{
    [ContentType(DisplayName = "General Page", GUID = "f3e1c7b0-4d2a-4c9e-9f5b-1a2b3c4d5e6f", 
        Description = "A general page type.",GroupName = SystemTabNames.Content)]
    public class GeneralPage:PageData
    {
        [Display( 
            Name = "Headline", 
            GroupName = "Content",
            Order = 10)
            ]
        public virtual string? Headline { get; set; }

        [Display(
            Name = "Headline Slug",
            GroupName = "Content",
            Order = 20)
            ]
        public virtual string? HeadlineSlug { get; set; }

        [Display(
            Name = "Body",
            GroupName = "Content",
            Order = 30)
            ]
        public virtual XhtmlString? Body { get; set; }
    }
}
