using System.ComponentModel;

namespace RoshanTarAzAftab.Domain.Enums;

public enum CategoryType
{
    [Description("تاریخ اسلام")]
    IslamicHistory = 0,
    [Description("تاریخ باستان")]
    IranHistory = 1,
    [Description("فلسفه و عرفان")]
    Mysticism = 1,
}
