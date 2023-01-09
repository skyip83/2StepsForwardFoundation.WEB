using System;
using System.ComponentModel.DataAnnotations;

namespace _2StepsForwardFoundation.Models
{
    public class EmailMetadata
    {
        public int EmailId { get; set; }

        [Required(ErrorMessage = "Sender is required")]
        [EmailAddress]
        [StringLength(320, ErrorMessage = "Sender must be less than 320 characters")]
        [Display(Name = "Your Email")]
        public string Sender { get; set; }

        public string Recipient { get; set; }

        [Required(ErrorMessage = "Subject is required")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [Display(Name = "Message")]
        public string Message { get; set; }

        public DateTime CreationDateTime { get; set; }
    }

    public class EmailingListMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        [StringLength(320, ErrorMessage = "Email must be less than 320 characters")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public DateTime CreationDateTime { get; set; }
    }

    public class ApplicationMetadata
    {
        public int ApplicationId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name must be less than 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [StringLength(50, ErrorMessage = "Middle name must be less than 50 characters")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name must be less than 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address must be less than 100 characters")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        
        [StringLength(100, ErrorMessage = "Address line 2 must be less than 100 characters")]
        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(50, ErrorMessage = "City must be less than 50 characters")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(20, ErrorMessage = "State must be less than 20 characters")]
        [Display(Name = "State")]
        public string State { get; set; }
        
        [StringLength(10, ErrorMessage = "Zip must be less than 10 characters")]
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }
        
        [EmailAddress]
        [StringLength(320, ErrorMessage = "Email must be less than 320 characters")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(50, ErrorMessage = "Phone number must be less than 50 characters")]
        [Display(Name = "Home/Cell Phone")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Place of employment is required")]
        [StringLength(100, ErrorMessage = "Place of employment must be less than 100 characters")]
        [Display(Name = "Place of Employment")]
        public string PlaceOfEmployment { get; set; }
        
        [Required(ErrorMessage = "Total income is required")]
        [Display(Name = "Total annual household income (include all sources of income")]
        public decimal TotalIncome { get; set; }

        [Required(ErrorMessage = "Amount needed is required")]
        [Display(Name = "Amount Needed")]
        public decimal AmountNeeded { get; set; }

        [Display(Name = "Have you ever applied for assistance with 2 Steps Forward Foundation?")]
        public bool AppliedBefore { get; set; }
        
        [Display(Name = "Was assistance provided?")]
        public bool? AssistanceProvided { get; set; }
        
        [Display(Name = "Bill Requesting Payment for")]
        public string BillRequestingPayment { get; set; }
        
        [Display(Name = "Do you receive any type of government assistance (if so list)")]
        public bool GovernmentAssistance { get; set; }
        
        [Display(Name = "Details")]
        public string GovernmentAssistanceDetails { get; set; }
        
        [Display(Name = "Other assistance applied for")]
        public string OtherAssistanceAppliedDetails { get; set; }

        [Required(ErrorMessage = "Household member 1's name and age is required")]
        [StringLength(100, ErrorMessage = "Household member 1's name and age must be less than 100 characters")]
        [Display(Name = "Name & Age of household member 1")]
        public string HouseholdMemberNameAge1 { get; set; }

        [StringLength(100, ErrorMessage = "Household member 2's name and age must be less than 100 characters")]
        [Display(Name = "Name & Age of household member 2")]
        public string HouseholdMemberNameAge2 { get; set; }

        [StringLength(100, ErrorMessage = "Household member 3's name and age must be less than 100 characters")]
        [Display(Name = "Name & Age of household member 3")]
        public string HouseholdMemberNameAge3 { get; set; }

        [StringLength(100, ErrorMessage = "Household member 4's name and age must be less than 100 characters")]
        [Display(Name = "Name & Age of household member 4")]
        public string HouseholdMemberNameAge4 { get; set; }

        [StringLength(100, ErrorMessage = "Household member 5's name and age must be less than 100 characters")]
        [Display(Name = "Name & Age of household member 5")]
        public string HouseholdMemberNameAge5 { get; set; }

        [StringLength(100, ErrorMessage = "Household member 6's name and age must be less than 100 characters")]
        [Display(Name = "Name & Age of household member 6")]
        public string HouseholdMemberNameAge6 { get; set; }

        [Required(ErrorMessage = "Need for assistance explanation is required")]
        [Display(Name = "Please explain your need for assistance")]
        public string AssistanceNeedExplanation { get; set; }
        
        [Display(Name = "Are there any other factors we should consider in reviewing your application?")]
        public string OtherFactorsToReview { get; set; }

        public DateTime CreationDateTime { get; set; }
    }

    public class VolunteerMetadata
    {
        public int VolunteerId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name must be less than 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Middle name must be less than 50 characters")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name must be less than 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address must be less than 100 characters")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [StringLength(100, ErrorMessage = "Address line 2 must be less than 100 characters")]
        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(50, ErrorMessage = "City must be less than 50 characters")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(20, ErrorMessage = "State must be less than 20 characters")]
        [Display(Name = "State")]
        public string State { get; set; }

        [StringLength(10, ErrorMessage = "Zip must be less than 10 characters")]
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }

        [EmailAddress]
        [StringLength(320, ErrorMessage = "Email must be less than 320 characters")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(50, ErrorMessage = "Phone number must be less than 50 characters")]
        [Display(Name = "Home/Cell Phone")]
        public string PhoneNumber { get; set; }
        
        [Display(Name = "Background")]
        public string Background { get; set; }

        public DateTime CreationDateTime { get; set; }
    }
}