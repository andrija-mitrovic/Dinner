using ErrorOr;

namespace Dinner.Domain.Common.Errors
{
    public static partial class Errors
    {
        public static class User
        {
            public static Error DuplicateEmail => Error.Conflict(
                code: "User.DuplicateEmial", 
                description: "Email is already in use.");
        }
    }
}
