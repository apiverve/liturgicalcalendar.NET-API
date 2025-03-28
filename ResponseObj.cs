using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("dateArgs")]
    public int[] dateArgs { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250301
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("dateArgs")]
    public int[] dateArgs { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250302
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("dateArgs")]
    public int[] dateArgs { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250303
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("dateArgs")]
    public int[] dateArgs { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250304
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250305
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250306
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250307
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250308
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250309
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250310
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250311
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250312
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250313
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250314
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250315
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250316
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250317
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250318
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("month")]
    public int month { get; set; }

    [JsonProperty("date")]
    public int date { get; set; }

}

public class setDate
{
    [JsonProperty("addDay")]
    public int addDay { get; set; }

}

public class dateExceptions
{
    [JsonProperty("ifIsDayOfWeek")]
    public int ifIsDayOfWeek { get; set; }

    [JsonProperty("setDate")]
    public setDate setDate { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250319
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public dateExceptions[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public string[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250320
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250321
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250322
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250323
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250324
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250325
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public string[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250326
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250327
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250328
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250329
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250330
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class dateDef
{
    [JsonProperty("dateFn")]
    public string dateFn { get; set; }

    [JsonProperty("addDay")]
    public int addDay { get; set; }

    [JsonProperty("yearOffset")]
    public int yearOffset { get; set; }

}

public class calendar
{
    [JsonProperty("weekOfSeason")]
    public int weekOfSeason { get; set; }

    [JsonProperty("dayOfSeason")]
    public int dayOfSeason { get; set; }

    [JsonProperty("dayOfWeek")]
    public int dayOfWeek { get; set; }

    [JsonProperty("nthDayOfWeekInMonth")]
    public int nthDayOfWeekInMonth { get; set; }

    [JsonProperty("startOfSeason")]
    public string startOfSeason { get; set; }

    [JsonProperty("endOfSeason")]
    public string endOfSeason { get; set; }

    [JsonProperty("startOfLiturgicalYear")]
    public string startOfLiturgicalYear { get; set; }

    [JsonProperty("endOfLiturgicalYear")]
    public string endOfLiturgicalYear { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

}

public class cycles
{
    [JsonProperty("properCycle")]
    public string properCycle { get; set; }

    [JsonProperty("sundayCycle")]
    public string sundayCycle { get; set; }

    [JsonProperty("weekdayCycle")]
    public string weekdayCycle { get; set; }

    [JsonProperty("psalterWeek")]
    public string psalterWeek { get; set; }

}

public class 20250331
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("dateDef")]
    public dateDef dateDef { get; set; }

    [JsonProperty("dateExceptions")]
    public object[] dateExceptions { get; set; }

    [JsonProperty("alternativeTransferDateDefs")]
    public object[] alternativeTransferDateDefs { get; set; }

    [JsonProperty("precedence")]
    public string precedence { get; set; }

    [JsonProperty("rank")]
    public string rank { get; set; }

    [JsonProperty("allowSimilarRankItems")]
    public bool allowSimilarRankItems { get; set; }

    [JsonProperty("isHolyDayOfObligation")]
    public bool isHolyDayOfObligation { get; set; }

    [JsonProperty("isOptional")]
    public bool isOptional { get; set; }

    [JsonProperty("i18nDef")]
    public string[] i18nDef { get; set; }

    [JsonProperty("seasons")]
    public string[] seasons { get; set; }

    [JsonProperty("periods")]
    public string[] periods { get; set; }

    [JsonProperty("colors")]
    public string[] colors { get; set; }

    [JsonProperty("commonsDef")]
    public object[] commonsDef { get; set; }

    [JsonProperty("martyrology")]
    public object[] martyrology { get; set; }

    [JsonProperty("titles")]
    public object[] titles { get; set; }

    [JsonProperty("calendar")]
    public calendar calendar { get; set; }

    [JsonProperty("cycles")]
    public cycles cycles { get; set; }

    [JsonProperty("fromCalendarId")]
    public string fromCalendarId { get; set; }

    [JsonProperty("fromExtendedCalendars")]
    public object[] fromExtendedCalendars { get; set; }

}

public class data
{
    [JsonProperty("2025-03-01")]
    public 20250301[] 20250301 { get; set; }

    [JsonProperty("2025-03-02")]
    public 20250302[] 20250302 { get; set; }

    [JsonProperty("2025-03-03")]
    public 20250303[] 20250303 { get; set; }

    [JsonProperty("2025-03-04")]
    public 20250304[] 20250304 { get; set; }

    [JsonProperty("2025-03-05")]
    public 20250305[] 20250305 { get; set; }

    [JsonProperty("2025-03-06")]
    public 20250306[] 20250306 { get; set; }

    [JsonProperty("2025-03-07")]
    public 20250307[] 20250307 { get; set; }

    [JsonProperty("2025-03-08")]
    public 20250308[] 20250308 { get; set; }

    [JsonProperty("2025-03-09")]
    public 20250309[] 20250309 { get; set; }

    [JsonProperty("2025-03-10")]
    public 20250310[] 20250310 { get; set; }

    [JsonProperty("2025-03-11")]
    public 20250311[] 20250311 { get; set; }

    [JsonProperty("2025-03-12")]
    public 20250312[] 20250312 { get; set; }

    [JsonProperty("2025-03-13")]
    public 20250313[] 20250313 { get; set; }

    [JsonProperty("2025-03-14")]
    public 20250314[] 20250314 { get; set; }

    [JsonProperty("2025-03-15")]
    public 20250315[] 20250315 { get; set; }

    [JsonProperty("2025-03-16")]
    public 20250316[] 20250316 { get; set; }

    [JsonProperty("2025-03-17")]
    public 20250317[] 20250317 { get; set; }

    [JsonProperty("2025-03-18")]
    public 20250318[] 20250318 { get; set; }

    [JsonProperty("2025-03-19")]
    public 20250319[] 20250319 { get; set; }

    [JsonProperty("2025-03-20")]
    public 20250320[] 20250320 { get; set; }

    [JsonProperty("2025-03-21")]
    public 20250321[] 20250321 { get; set; }

    [JsonProperty("2025-03-22")]
    public 20250322[] 20250322 { get; set; }

    [JsonProperty("2025-03-23")]
    public 20250323[] 20250323 { get; set; }

    [JsonProperty("2025-03-24")]
    public 20250324[] 20250324 { get; set; }

    [JsonProperty("2025-03-25")]
    public 20250325[] 20250325 { get; set; }

    [JsonProperty("2025-03-26")]
    public 20250326[] 20250326 { get; set; }

    [JsonProperty("2025-03-27")]
    public 20250327[] 20250327 { get; set; }

    [JsonProperty("2025-03-28")]
    public 20250328[] 20250328 { get; set; }

    [JsonProperty("2025-03-29")]
    public 20250329[] 20250329 { get; set; }

    [JsonProperty("2025-03-30")]
    public 20250330[] 20250330 { get; set; }

    [JsonProperty("2025-03-31")]
    public 20250331[] 20250331 { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
