using Dinner.Domain.Entities;

namespace Dinner.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token);
