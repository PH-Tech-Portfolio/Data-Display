using System;
using System.Collections.Generic;

namespace CovidDataDisplay.Models;

public partial class Covid19AlbertaStatisticsDatum
{
    public int Id { get; set; }

    public DateTime? DateReported { get; set; }

    public string? AlbertaHealthServicesZone { get; set; }

    public string? Gender { get; set; }

    public string? AgeGroup { get; set; }

    public string? DeathStatus { get; set; }

    public string? CaseType { get; set; }
}
