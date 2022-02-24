using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace HoliDayRental.Infrastructure.Helpers
{

    [HtmlTargetElement("picto", Attributes = "text")]
    [EditorBrowsable(EditorBrowsableState.Never)]    
    public class PictoTagHelper : TagHelper
    {
       
        public override async Task ProcessAsync(TagHelperContext context,
                                                TagHelperOutput output)
        {

           
               output.TagName = "span";    // Replaces <picto> with <a> tag
               

            if (string.Equals(context.TagName, "picto",
                    StringComparison.OrdinalIgnoreCase)  )
            {
                //Ajout des attributs data-
                output.Attributes.SetAttribute("data-toggle", "tooltip");
                output.Attributes.SetAttribute("data-placement", "bottom");
                output.Attributes.SetAttribute("data-original-title", context.AllAttributes["text"].Value);

                string image = getImage(context.AllAttributes["text"].Value.ToString());

                var content = await output.GetChildContentAsync();
                output.Content.SetHtmlContent(
                    $"<img src='/images/icones/{image}' width='25'/>");
            }
        }

        private string getImage(string value)
        {
            switch (value)
            {
                case "Chien admis": return "chien.png";
                case "Lave Linge": return "laveLinge.png";
                case "Lave vaisselle": return "lavevaiselle.png";
                case "Wifi": return "wifi.png";
                case "Parking": return "parking.png";
                case "Piscine": return "piscine.png";
                case "Feu ouvert": return "feuxouvert.png";
                case "Lit enfant": return "litenfant.png";
                case "WC": return "wc.png";
                case "Salle de bain": return "bath-tub.png";
                case "Barbecue": return "grill-barbecue.png";
                case "Cuisine": return "ustensiles-de-cuisine.png";
                case "Lit Double": return "chambre.png";
                case "Salon": return "salon.png";
                default: return "";
            }
        }
    }
}
