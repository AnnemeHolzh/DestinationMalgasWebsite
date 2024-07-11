using Firebase.Database;
using Firebase.Database.Query;
using DestinationMalgasWebsite.DatabaseModels;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

public class FirebaseService
{
    private readonly FirebaseClient _firebaseClient;

    public FirebaseService()
    {
        _firebaseClient = new FirebaseClient("https://your-database-name.firebaseio.com/");
    }

    public async Task AddUser(User user)
    {
        await _firebaseClient.Child("users").PostAsync(user);
    }

    public async Task AddProperty(Property property)
    {
        await _firebaseClient.Child("properties").PostAsync(property);
    }

    public async Task AddAmenity(Amenity amenity)
    {
        await _firebaseClient.Child("amenities").PostAsync(amenity);
    }

    public async Task<List<Property>> GetProperties()
    {
        var properties = await _firebaseClient.Child("properties").OnceAsync<Property>();
        List<Property> propertyList = new List<Property>();
        foreach (var property in properties)
        {
            propertyList.Add(property.Object);
        }
        return propertyList;
    }
}

