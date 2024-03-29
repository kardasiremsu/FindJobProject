﻿using System.ComponentModel.DataAnnotations;

namespace BitirmeProj.Models
{
    public class Language
    {
        [Key]
        public int LanguageID { get; set; }
        public int Name { get; set; }

        // Navigation property
        public ICollection<CVLanguage> CVLanguages { get; set; }
    }
}
