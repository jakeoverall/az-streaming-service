using Azure.Identity;
using Microsoft.Azure.Management.Media;
using Microsoft.Rest;

public class AzureMediaServiceProvider
{
  public static AzureMediaServicesClient InitializeAzureMediaService()
  {
    var clientId = GetSecret("ClientId");
    var clientSecret = GetSecret("ClientSecret");
    var tenantId = GetSecret("TenantId");


    return new AzureMediaServicesClient() { SubscriptionId = GetSecret("SubscriptionId") };
  }

  private static string GetSecret(string secretName)
  {
    // Retrieve secrets from Azure Key Vault
    // ...
    return "";
  }
}

