//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2StepsForwardFoundation.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Volunteer> Volunteers { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<EmailingList> EmailingLists { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
    
        public virtual int usp_CreateEmail(string sender, string recipient, string subject, string message)
        {
            var senderParameter = sender != null ?
                new ObjectParameter("Sender", sender) :
                new ObjectParameter("Sender", typeof(string));
    
            var recipientParameter = recipient != null ?
                new ObjectParameter("Recipient", recipient) :
                new ObjectParameter("Recipient", typeof(string));
    
            var subjectParameter = subject != null ?
                new ObjectParameter("Subject", subject) :
                new ObjectParameter("Subject", typeof(string));
    
            var messageParameter = message != null ?
                new ObjectParameter("Message", message) :
                new ObjectParameter("Message", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_CreateEmail", senderParameter, recipientParameter, subjectParameter, messageParameter);
        }
    
        public virtual int usp_EmailingListMaintenance(string email, string action)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_EmailingListMaintenance", emailParameter, actionParameter);
        }
    
        public virtual int usp_ApplicationMaintenance(string firstName, string middleName, string lastName, string address, string address2, string city, string state, string zip, string email, string phoneNumber, string placeOfEmployment, Nullable<decimal> totalIncome, Nullable<decimal> amountNeeded, Nullable<bool> appliedBefore, Nullable<bool> assistanceProvided, string billRequestingPayment, Nullable<bool> governmentAssistance, string governmentAssistanceDetails, string otherAssistanceAppliedDetails, string householdMemberNameAge1, string householdMemberNameAge2, string householdMemberNameAge3, string householdMemberNameAge4, string householdMemberNameAge5, string householdMemberNameAge6, string assistanceNeedExplanation, string otherFactorsToReview, string action)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("MiddleName", middleName) :
                new ObjectParameter("MiddleName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("Address2", address2) :
                new ObjectParameter("Address2", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var zipParameter = zip != null ?
                new ObjectParameter("Zip", zip) :
                new ObjectParameter("Zip", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var placeOfEmploymentParameter = placeOfEmployment != null ?
                new ObjectParameter("PlaceOfEmployment", placeOfEmployment) :
                new ObjectParameter("PlaceOfEmployment", typeof(string));
    
            var totalIncomeParameter = totalIncome.HasValue ?
                new ObjectParameter("TotalIncome", totalIncome) :
                new ObjectParameter("TotalIncome", typeof(decimal));
    
            var amountNeededParameter = amountNeeded.HasValue ?
                new ObjectParameter("AmountNeeded", amountNeeded) :
                new ObjectParameter("AmountNeeded", typeof(decimal));
    
            var appliedBeforeParameter = appliedBefore.HasValue ?
                new ObjectParameter("AppliedBefore", appliedBefore) :
                new ObjectParameter("AppliedBefore", typeof(bool));
    
            var assistanceProvidedParameter = assistanceProvided.HasValue ?
                new ObjectParameter("AssistanceProvided", assistanceProvided) :
                new ObjectParameter("AssistanceProvided", typeof(bool));
    
            var billRequestingPaymentParameter = billRequestingPayment != null ?
                new ObjectParameter("BillRequestingPayment", billRequestingPayment) :
                new ObjectParameter("BillRequestingPayment", typeof(string));
    
            var governmentAssistanceParameter = governmentAssistance.HasValue ?
                new ObjectParameter("GovernmentAssistance", governmentAssistance) :
                new ObjectParameter("GovernmentAssistance", typeof(bool));
    
            var governmentAssistanceDetailsParameter = governmentAssistanceDetails != null ?
                new ObjectParameter("GovernmentAssistanceDetails", governmentAssistanceDetails) :
                new ObjectParameter("GovernmentAssistanceDetails", typeof(string));
    
            var otherAssistanceAppliedDetailsParameter = otherAssistanceAppliedDetails != null ?
                new ObjectParameter("OtherAssistanceAppliedDetails", otherAssistanceAppliedDetails) :
                new ObjectParameter("OtherAssistanceAppliedDetails", typeof(string));
    
            var householdMemberNameAge1Parameter = householdMemberNameAge1 != null ?
                new ObjectParameter("HouseholdMemberNameAge1", householdMemberNameAge1) :
                new ObjectParameter("HouseholdMemberNameAge1", typeof(string));
    
            var householdMemberNameAge2Parameter = householdMemberNameAge2 != null ?
                new ObjectParameter("HouseholdMemberNameAge2", householdMemberNameAge2) :
                new ObjectParameter("HouseholdMemberNameAge2", typeof(string));
    
            var householdMemberNameAge3Parameter = householdMemberNameAge3 != null ?
                new ObjectParameter("HouseholdMemberNameAge3", householdMemberNameAge3) :
                new ObjectParameter("HouseholdMemberNameAge3", typeof(string));
    
            var householdMemberNameAge4Parameter = householdMemberNameAge4 != null ?
                new ObjectParameter("HouseholdMemberNameAge4", householdMemberNameAge4) :
                new ObjectParameter("HouseholdMemberNameAge4", typeof(string));
    
            var householdMemberNameAge5Parameter = householdMemberNameAge5 != null ?
                new ObjectParameter("HouseholdMemberNameAge5", householdMemberNameAge5) :
                new ObjectParameter("HouseholdMemberNameAge5", typeof(string));
    
            var householdMemberNameAge6Parameter = householdMemberNameAge6 != null ?
                new ObjectParameter("HouseholdMemberNameAge6", householdMemberNameAge6) :
                new ObjectParameter("HouseholdMemberNameAge6", typeof(string));
    
            var assistanceNeedExplanationParameter = assistanceNeedExplanation != null ?
                new ObjectParameter("AssistanceNeedExplanation", assistanceNeedExplanation) :
                new ObjectParameter("AssistanceNeedExplanation", typeof(string));
    
            var otherFactorsToReviewParameter = otherFactorsToReview != null ?
                new ObjectParameter("OtherFactorsToReview", otherFactorsToReview) :
                new ObjectParameter("OtherFactorsToReview", typeof(string));
    
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ApplicationMaintenance", firstNameParameter, middleNameParameter, lastNameParameter, addressParameter, address2Parameter, cityParameter, stateParameter, zipParameter, emailParameter, phoneNumberParameter, placeOfEmploymentParameter, totalIncomeParameter, amountNeededParameter, appliedBeforeParameter, assistanceProvidedParameter, billRequestingPaymentParameter, governmentAssistanceParameter, governmentAssistanceDetailsParameter, otherAssistanceAppliedDetailsParameter, householdMemberNameAge1Parameter, householdMemberNameAge2Parameter, householdMemberNameAge3Parameter, householdMemberNameAge4Parameter, householdMemberNameAge5Parameter, householdMemberNameAge6Parameter, assistanceNeedExplanationParameter, otherFactorsToReviewParameter, actionParameter);
        }
    
        public virtual int usp_VolunteerMaintenance(string firstName, string middleName, string lastName, string address, string address2, string city, string state, string zip, string email, string phoneNumber, string background, string action)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("MiddleName", middleName) :
                new ObjectParameter("MiddleName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("Address2", address2) :
                new ObjectParameter("Address2", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var zipParameter = zip != null ?
                new ObjectParameter("Zip", zip) :
                new ObjectParameter("Zip", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var backgroundParameter = background != null ?
                new ObjectParameter("Background", background) :
                new ObjectParameter("Background", typeof(string));
    
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_VolunteerMaintenance", firstNameParameter, middleNameParameter, lastNameParameter, addressParameter, address2Parameter, cityParameter, stateParameter, zipParameter, emailParameter, phoneNumberParameter, backgroundParameter, actionParameter);
        }
    }
}
