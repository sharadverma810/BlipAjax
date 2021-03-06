﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Blip.Entities.Customers.ViewModels
{
    public class AddressTypeViewModel
    {
        [StringLength(38)]
        public string CustomerID { get; set; } // Carries the value in POST action.

        [Display(Name = "Address Type")]
        public string SelectedAddressType { get; set; }
        public IEnumerable<SelectListItem> AddressTypes { get; set; }
    }
}
