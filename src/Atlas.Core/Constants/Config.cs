namespace Atlas.Core.Constants
{
    public static class Config
    {
        public const string ATLAS_API = "AtlasAPI";
        public const string CONNECTION_STRING = "AtlasConnection";
        public const string OIDC_AUTHORITY = "OpenIddict:Authority";
        public const string OIDC_AUDIENCE = "OpenIddict:Audience";
        public const string OIDC_CLIENT_ID = "OpenIddict:ClientId";
        public const string OIDC_CLIENT_SECRET = "OpenIddict:ClientSecret";
        public const string CORS_POLICY = "CorsOrigins:Policy";
        public const string ORIGINS_URLS = "CorsOrigins:Urls";
        public const string DATABASE_MIGRATION = "Database:MigrateDatabase";
        public const string DATABASE_CREATE = "Database:CreateDatabase";
        public const string DATABASE_SEED_DATA = "Database:GenerateSeedData";
        public const string DATABASE_SEED_LOGS = "Database:GenerateSeedLogs";
    }
}
