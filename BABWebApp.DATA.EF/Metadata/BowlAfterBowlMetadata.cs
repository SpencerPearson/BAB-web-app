using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABWebApp.DATA.EF
{
    #region Art Sub Metadata
    public class ArtSubMetadata
    {
        [Required]
        public string Image { get; set; }

        [Required]
        [Display(Name = "Artist ID")]
        public string ArtistId { get; set; }

        [Required]
        [Display(Name = "Date Submitted")]
        [DisplayFormat(DataFormatString = "{0:f}")]
        public DateTime DateSubmitted { get; set; }

        [Display(Name = "Artist's Value Address")]
        public string ValueAddress { get; set; }

    }
    [MetadataType(typeof(ArtSubMetadata))]
    public partial class ArtSub
    {

    }
    #endregion

    #region Chapter Metadata
    public class ChapterMetadata
    {
        [Required]
        [Display(Name = "Episode ID")]
        public int EpisodeId { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:hh:mm:ss}")]
        public TimeSpan StartTime { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:hh:mm:ss}")]
        public TimeSpan Duration { get; set; }

        [Required]
        [Display(Name = "Chapter Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Chapter Description")]
        [UIHint("MultilineText")]
        public string Description { get; set; }
    }
    [MetadataType(typeof(ChapterMetadata))]
    public partial class Chapter
    {

    }
    #endregion

    #region Clip Sub Metadata
    
    public partial class ClipSubMetadata
    {
        [Required]
        public string Clip { get; set; }

        [Required]
        [Display(Name = "Producer ID")]
        public string ProducerId { get; set; }

        [Display(Name = "Clip Source")]
        public string SourceName { get; set; }

        [Display(Name = "Clip Description")]
        [DisplayFormat(NullDisplayText = "-No Description-")]
        [UIHint("MultilineText")]
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh:mm:ss}")]
        public TimeSpan Duration { get; set; }
    }
    [MetadataType(typeof(ClipSubMetadata))]
    public partial class ClipSub
    {

    }

    #endregion

    #region Donation Metadata
    public class DonationMetadata
    {
        [Required]
        [Display(Name = "Donor Name")]
        public string DonorName { get; set; }

        [Required]
        [Display(Name = "Date Received")]
        [DisplayFormat(DataFormatString = "{0:g}")]
        public DateTime DateReceived { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        [Display(Name = "Currency ID")]
        public int CurrencyId { get; set; }

        public string UserId { get; set; }

        [Required]
        [Display(Name = "Anonymous?")]
        public bool IsAnon { get; set; }

        [Display(Name = "Donation Note")]
        [DisplayFormat(NullDisplayText = "-No Note-")]
        [UIHint("MultilineText")]
        public string DonationNote { get; set; }

        [Required]
        [Display(Name = "Episode ID")]
        public int EpisodeId { get; set; }

        [Display(Name = "Credit Donation To")]
        [DisplayFormat(NullDisplayText = "- N/A -")]
        public string CreditTo { get; set; }

    }
    [MetadataType(typeof(DonationMetadata))]
    public partial class Donation
    {

    }
    #endregion

    #region Episode Metadata
    public class EpisodeMetadata
    {
        [Required]
        [Display(Name = "Episode Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Podcast ID")]
        public int PodcastId { get; set; }

        [Display(Name = "Episode Descripton")]
        [UIHint("MultilineText")]
        [DisplayFormat(NullDisplayText = "-No Description-")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Episode Permalink")]
        public string Link { get; set; }

        [Required]
        [Display(Name = "Date Published")]
        [DisplayFormat(DataFormatString = "{0:g}")]
        public DateTime Published { get; set; }

        [Display(Name = "Episode Author")]
        public string Author { get; set; }

        [Display(Name = "Episode Artwork")]
        public string Artwork { get; set; }

        [Display(Name = "Episode Number")]
        public short EpisodeNumber { get; set; }

        [Display(Name = "Episode Length")]
        [DisplayFormat(DataFormatString = "{0:g}")]
        public TimeSpan Duration { get; set; }

        [Required]
        [Display(Name = "Audio File")]
        public string AudioFile { get; set; }
    }

    [MetadataType(typeof(EpisodeMetadata))]
    public partial class Episode
    {

    }
    #endregion

    #region Podcast Metadata
    public class PodcastMetadata
    {
        [Required]
        [Display(Name = "Podcast Title")]
        public string Title { get; set; }

        [Display(Name = "Podcast Description")]
        [UIHint("MultilineText")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Podcast Website")]
        public string Link { get; set; }

        [Required]
        [Display(Name = "Last Published")]
        [DisplayFormat(DataFormatString = "{0:g}")]
        public DateTime Published { get; set; }

        [Display(Name = "Managing Editor")]
        public string ManagingEditor { get; set; }

        [Display(Name = "Web Master")]
        public string WebMaster { get; set; }

        [Display(Name = "Image URL")]
        public string Image { get; set; }

        [Required]
        [Display(Name = "Locked?")]
        public bool IsLocked { get; set; }

        [DisplayFormat(NullDisplayText = "-No Funding Specified-")]
        public string Funding { get; set; }

        [Display(Name = "iTunes Author")]
        public string ItunesAuthor { get; set; }

        [Display(Name = "Explicit content?")]
        public bool IsExplicit { get; set; }
    }
    [MetadataType(typeof(PodcastMetadata))]
    public partial class Podcast
    {

    }
    #endregion

    #region Soundbite Metadata
    public class SoundbiteMetadata
    {
        [Required]
        [Display(Name = "Episode ID")]
        public int EpisodeId { get; set; }

        [Required]
        [Display(Name = "Start Time")]
        [DisplayFormat(DataFormatString = "{0:g}")]
        public TimeSpan StartTime { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:g}")]
        public TimeSpan Duration { get; set; }

        [Required]
        [Display(Name = "Producer ID")]
        public string ProducerId { get; set; }
    }
    [MetadataType(typeof(Soundbite))]
    public partial class Soundbite
    {

    }
    #endregion

    #region User Detail Metadata
    public class UserDetailMetadata
    {
        [Required]
        [StringLength(50, ErrorMessage = "Nickname cannot exceed 50 characters.")]
        public string Nickname { get; set; }

        [Required]
        [Display(Name = "Profile Image")]
        public string ProfileImage { get; set; }

        [StringLength(50, ErrorMessage = "Location name cannot exceed 50 characters.")]
        public string Location { get; set; }
    }
    [MetadataType(typeof(UserDetailMetadata))]
    public partial class UserDetail
    {

    }
    #endregion
}
