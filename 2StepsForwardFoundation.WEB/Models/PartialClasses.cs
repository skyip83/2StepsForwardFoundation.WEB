using System.ComponentModel.DataAnnotations;

namespace _2StepsForwardFoundation.Models
{
    [MetadataType(typeof(EmailMetadata))]
    public partial class Email
    {
    }

    [MetadataType(typeof(EmailingListMetadata))]
    public partial class EmailingList
    {
    }

    [MetadataType(typeof(ApplicationMetadata))]
    public partial class Application
    {
    }

    [MetadataType(typeof(VolunteerMetadata))]
    public partial class Volunteer
    {
    }
}