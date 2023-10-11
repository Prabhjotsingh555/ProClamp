using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ProClamp.Models // Show view model for displaying a list of Clamps filtered by material and type.
{
    public class ClampTypeViewModel
    {
        public List<Clamp>Clamps { get; set; } // List of Clamps for dislay in the view.
        public SelectList Type { get; set; } //filtered unique list of clamp type
        public string ClampType { get; set; } // choosed clamp type for filtering
        public string SearchString { get; set; } // this string filter the clamps through the material
    }
}