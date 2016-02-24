using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace Vote.Models
{
    #region new code
    public class SetZipCodeViewModel
    {
        [Required]
        [StringLength(5, ErrorMessage = "The {0} must be {2} numbers long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Set ZipCode")]
        public string setZip { get; set; }
    }

    public class ChangeZipCodeViewModel
    {
        [Required]
        [StringLength(5, ErrorMessage = "The {0} must be {2} numbers long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Change ZipCode")]
        public string newZip { get; set; }
    }

    public class SetCityViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be {2} letters long.", MinimumLength = 10)]
        [DataType(DataType.Text)]
        [Display(Name = "New City")]
        public string setCity { get; set; }
    }

    public class ChangeCityViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be {2} letters long.", MinimumLength = 10)]
        [DataType(DataType.Text)]
        [Display(Name = "Change City")]
        public string newCity { get; set; }
    }

    public class SetAddressViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be {2} numbers long.", MinimumLength = 10)]
        [DataType(DataType.Text)]
        [Display(Name = "New Address")]
        public string setAddress { get; set; }
    }

    public class ChangeAddressViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be {2} numbers long.", MinimumLength = 10)]
        [DataType(DataType.Text)]
        [Display(Name = "Change Address")]
        public string newAddress { get; set; }
    }
    #endregion

    public class IndexViewModel
    {
        public bool HasAddress { get; set; }
        public bool HasZip { get; set; }
        public bool HasCity { get; set; }
        public bool HasState { get; set; }
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public bool BrowserRemembered { get; set; }
    }

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class FactorViewModel
    {
        public string Purpose { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }   
}