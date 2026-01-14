using Microsoft.AspNetCore.Mvc;
using Google.Cloud.Firestore;
using System.Linq;
using System.Threading.Tasks;

namespace cramrades.Controllerss
{
    public class DiscoverController : Controller
    {
        // Replace with your actual Firebase Project ID found in your config
        private readonly FirestoreDb _db = FirestoreDb.Create("cramrades");

        public async Task<IActionResult> Index()
        {
            // 1. In a real scenario, you'd get the UID from a session or cookie.
            // For testing, we'll assume a UID is stored or hardcoded.
            string currentUserId = "test_user_123"; 

            // 2. Get the current user's profile to see their location and preference
            DocumentReference userRef = _db.Collection("users").Document(currentUserId);
            DocumentSnapshot userSnap = await userRef.GetSnapshotAsync();

            if (!userSnap.Exists) {
                return RedirectToAction("ProfileSetup", "Auth");
            }

            var userData = userSnap.ToDictionary();
            string myLocation = userData["location"].ToString(); // e.g., "Region I"
            string myPreference = userData["preference"].ToString(); // e.g., "Female"

            // 3. Start a query for other users in the same region
            Query query = _db.Collection("users")
                            .WhereEqualTo("location", myLocation);

            // 4. Apply Gender Preference filter
            if (myPreference != "Everyone")
            {
                query = query.WhereEqualTo("gender", myPreference);
            }

            // 5. Execute and filter out the current user from the results
            QuerySnapshot snapshot = await query.GetSnapshotAsync();
            var matches = snapshot.Documents
                .Select(d => d.ToDictionary())
                .Where(d => d["uid"].ToString() != currentUserId)
                .ToList();

            return View(matches);
        }
    }
}