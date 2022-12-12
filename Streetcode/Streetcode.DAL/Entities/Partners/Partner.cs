﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTask.Entities.Partners;

[Table("partners", Schema = "partner_sponsors")]
public class Partner
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }
    
    public string? LogoUrl { get; set; }
    
    [Required]
    public string TargetUrl { get; set; }
    
    public string? Description { get; set; }

    public List<PartnerSourceLink> PartnerSourceLinks { get; set; } = new();
    
    public List<StreetcodePartner> StreetcodePartners { get; set; } = new();
}