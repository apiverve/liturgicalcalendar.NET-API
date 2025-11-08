using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// DateDef data
    /// </summary>
    public class DateDef
    {
        [JsonProperty("dateFn")]
        public string DateFn { get; set; }

        [JsonProperty("dateArgs")]
        public int[] DateArgs { get; set; }

        [JsonProperty("yearOffset")]
        public int YearOffset { get; set; }

    }
    /// <summary>
    /// Calendar data
    /// </summary>
    public class Calendar
    {
        [JsonProperty("weekOfSeason")]
        public int WeekOfSeason { get; set; }

        [JsonProperty("dayOfSeason")]
        public int DayOfSeason { get; set; }

        [JsonProperty("dayOfWeek")]
        public int DayOfWeek { get; set; }

        [JsonProperty("nthDayOfWeekInMonth")]
        public int NthDayOfWeekInMonth { get; set; }

        [JsonProperty("startOfSeason")]
        public string StartOfSeason { get; set; }

        [JsonProperty("endOfSeason")]
        public string EndOfSeason { get; set; }

        [JsonProperty("startOfLiturgicalYear")]
        public string StartOfLiturgicalYear { get; set; }

        [JsonProperty("endOfLiturgicalYear")]
        public string EndOfLiturgicalYear { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

    }
    /// <summary>
    /// Cycles data
    /// </summary>
    public class Cycles
    {
        [JsonProperty("properCycle")]
        public string ProperCycle { get; set; }

        [JsonProperty("sundayCycle")]
        public string SundayCycle { get; set; }

        [JsonProperty("weekdayCycle")]
        public string WeekdayCycle { get; set; }

        [JsonProperty("psalterWeek")]
        public string PsalterWeek { get; set; }

    }
    /// <summary>
    /// 20250301 data
    /// </summary>
    public class 20250301
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250302 data
    /// </summary>
    public class 20250302
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250303 data
    /// </summary>
    public class 20250303
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250304 data
    /// </summary>
    public class 20250304
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250305 data
    /// </summary>
    public class 20250305
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250306 data
    /// </summary>
    public class 20250306
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250307 data
    /// </summary>
    public class 20250307
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250308 data
    /// </summary>
    public class 20250308
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250309 data
    /// </summary>
    public class 20250309
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250310 data
    /// </summary>
    public class 20250310
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250311 data
    /// </summary>
    public class 20250311
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250312 data
    /// </summary>
    public class 20250312
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250313 data
    /// </summary>
    public class 20250313
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250314 data
    /// </summary>
    public class 20250314
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250315 data
    /// </summary>
    public class 20250315
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250316 data
    /// </summary>
    public class 20250316
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250317 data
    /// </summary>
    public class 20250317
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250318 data
    /// </summary>
    public class 20250318
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// SetDate data
    /// </summary>
    public class SetDate
    {
        [JsonProperty("addDay")]
        public int AddDay { get; set; }

    }
    /// <summary>
    /// DateExceptions data
    /// </summary>
    public class DateExceptions
    {
        [JsonProperty("ifIsDayOfWeek")]
        public int IfIsDayOfWeek { get; set; }

        [JsonProperty("setDate")]
        public SetDate SetDate { get; set; }

    }
    /// <summary>
    /// 20250319 data
    /// </summary>
    public class 20250319
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public DateExceptions[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public string[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250320 data
    /// </summary>
    public class 20250320
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250321 data
    /// </summary>
    public class 20250321
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250322 data
    /// </summary>
    public class 20250322
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250323 data
    /// </summary>
    public class 20250323
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250324 data
    /// </summary>
    public class 20250324
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250325 data
    /// </summary>
    public class 20250325
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public string[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250326 data
    /// </summary>
    public class 20250326
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250327 data
    /// </summary>
    public class 20250327
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250328 data
    /// </summary>
    public class 20250328
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250329 data
    /// </summary>
    public class 20250329
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250330 data
    /// </summary>
    public class 20250330
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// 20250331 data
    /// </summary>
    public class 20250331
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateDef")]
        public DateDef DateDef { get; set; }

        [JsonProperty("dateExceptions")]
        public object[] DateExceptions { get; set; }

        [JsonProperty("alternativeTransferDateDefs")]
        public object[] AlternativeTransferDateDefs { get; set; }

        [JsonProperty("precedence")]
        public string Precedence { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("allowSimilarRankItems")]
        public bool AllowSimilarRankItems { get; set; }

        [JsonProperty("isHolyDayOfObligation")]
        public bool IsHolyDayOfObligation { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("i18nDef")]
        public string[] I18nDef { get; set; }

        [JsonProperty("seasons")]
        public string[] Seasons { get; set; }

        [JsonProperty("periods")]
        public string[] Periods { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("commonsDef")]
        public object[] CommonsDef { get; set; }

        [JsonProperty("martyrology")]
        public object[] Martyrology { get; set; }

        [JsonProperty("titles")]
        public object[] Titles { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("cycles")]
        public Cycles Cycles { get; set; }

        [JsonProperty("fromCalendarId")]
        public string FromCalendarId { get; set; }

        [JsonProperty("fromExtendedCalendars")]
        public object[] FromExtendedCalendars { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
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
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
