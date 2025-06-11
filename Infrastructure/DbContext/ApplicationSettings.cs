using System;
namespace TdPlusDbContextGestion.Infrastructure.DbContext;


public class ApplicationSettings
{
    public const string SectionName = "ConnectionStrings";

    public string MySQL { get; set; } = null!;
}

