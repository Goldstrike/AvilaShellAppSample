﻿namespace AvilaShellApp.Services
{
    public static class ApiConfig
    {
        public static string FbApiBaseUrl = "https://graph.facebook.com";
        public static string FbApiPath = "/v8.0/coiffeursindependants";

        public static int FbApiCallTimeout = 15;
        public static int FbApiCallMaxRetries = 3;

        //public static string FbApiEventsParams = "/events?debug=all&format=json&method=get&pretty=0&suppress_http_code=1&transport=cors&access_token=";
        public static string FbApiEventsParams = $"/events?access_token=";
        public static int FbMaxEventsDisplayed = 3;

        //public static string FbApiPostsParams = "/posts?debug=all&fields=id%2Cmessage%2Ccreated_time%2Cpicture%2Cicon%2Cpermalink_url%2Cfull_picture%2Cstory%2Cstory_tags&format=json&method=get&pretty=0&suppress_http_code=1&transport=cors&limit=40";
        public static string FbApiPostsParams = $"/feed?fields=id,message,created_time,picture,icon,permalink_url,full_picture,story,story_tags&limit=50&access_token=";
        public static int FbMaxPostsDisplayed = 5;

        public static string FbAccessToken = "EAAYmP2nRRLYBACExrYukSsuBmSSOKY7NPxEm2bDkcZA7uomK5yobXPZCLPbixfYK87tT8AoAMbmdd3KUvTT5Ffew6jlsMFUYn31tgHhT3VrLDztHPUbPa1x45ynLwBIlHjPMofQ8ZB0RQN4bImXx9QWJoJ3karG4xeK7jJJ1gZDZD";

        public static string FbAvilaPageId = "115592608462989";
        public static string FbHourrappsPageId = "1702965483338996";
        public static string FbHourrappsPageUrl = "https://www.facebook.com/hourrapps";

        public static string WavyAvilaUrlBooking = "https://booking.wavy.pro/avila";
    }
}
