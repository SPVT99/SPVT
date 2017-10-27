using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;



namespace SPVT.Models
{
    public class CarsMakeViewModel
    {
        public List<Cars> cars;
        public SelectList Make;
        public string carsMake { get; set; }
    }
}