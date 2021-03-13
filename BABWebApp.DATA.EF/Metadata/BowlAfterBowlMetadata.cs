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
    }

    #endregion
}
