﻿using System;
namespace AvilaShellApp.Monitoring
{
    public static class EventName
    {
        // common events
        public const string NoInternetAccessRetry = "NoInternetAccessRetry";
        public const string ServiceIssueRetry = "ServiceIssueRetry";
        public const string TimeoutRetry = "TimeoutRetry";
        // NewsPage events
        public const string OpenNews = "OpenNews";
        public const string OpenEvent = "OpenEvent";
        // HomePage events
        public const string AvilaCall = "AvilaCall";
        public const string AvilaMail = "AvilaMail";
        public const string AvilaMap = "AvilaMap";
        // BookingPage events
        public const string RefreshBookingWebview = "RefreshBookingWebview";
        // AboutPage events
        public const string HourrappsCall = "HourrappsCall";
        public const string HourrappsMail = "HourrappsMail";
        public const string HourrappsWebsite = "HourrappsWebsite";
        public const string HourrappsFacebookPage = "HourrappsFacebookPage";
    }
}
