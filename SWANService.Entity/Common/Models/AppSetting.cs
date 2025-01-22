using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace DocsServer.Entity.Common.Models;

/// <summary>
/// Represents application settings loaded from configuration.
/// </summary>
public class AppSetting
{
    public string ConnectionString { get; set; }
    public string ReCaptchaSiteKey { get; set; }
    public string ReCaptchaSecretKey { get; set; }
    public string ReCaptchaUrl { get; set; }
    public string SendGridEmailApiKey { get; set; }
    public string SendGridValidationApiKey { get; set; }
    public string SendGridFromEmail { get; set; }
    public string ApplicationEmailValidationEnabled { get; set; }
}
