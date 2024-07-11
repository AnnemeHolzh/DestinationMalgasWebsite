using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

public class FirebaseConfig
{
    public static void Initialize()
    {
        FirebaseApp.Create(new AppOptions()
        {
            Credential = GoogleCredential.FromFile("App_Data/destinationmalgasdb-c1203-firebase-adminsdk-oy1xw-6197dba86d")
        });
    }
}
