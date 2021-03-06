namespace MvcCrudOperation.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class FootBallLeague
    {
        [Required (ErrorMessage ="Required")]
        public int MatchId { get; set; }
        [Required(ErrorMessage = "Required")]
        public string TeamName1 { get; set; }
        [Required(ErrorMessage = "Required")]
        public string TeamName2 { get; set; }
        [Required(ErrorMessage = "Required")]
        public string MatchStatus { get; set; }
        [Required(ErrorMessage = "Required")]
        public string WinningTeam { get; set; }
        [Required(ErrorMessage = "Required")]
        public int Points { get; set; }
    }
}