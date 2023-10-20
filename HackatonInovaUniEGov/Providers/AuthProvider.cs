using System.Security.Claims;
using HackatonInovaUniEGov.Controller;
using Microsoft.AspNetCore.Components.Authorization;

namespace HackatonInovaUniEGov.Providers;

public class AuthProvider  : AuthenticationStateProvider
{
    private AuthenticationState? _cachedAuthState;
    private readonly AuthController _authController;
    public AuthProvider(AuthController authController)
    {
        _authController = authController;
    }

    public async Task<AuthenticationState> Login(string email, string password)
    {
        var claims = await _authController.Login(email, password);
        if (claims.Any())
        {
            var identity = new ClaimsIdentity(claims, "jwt");
            var user = new ClaimsPrincipal(identity);
            _cachedAuthState = new AuthenticationState(user);
            NotifyAuthenticationStateChanged(Task.FromResult(_cachedAuthState));
        }

        return _cachedAuthState ?? new AuthenticationState(new ClaimsPrincipal());
    }

    public  void Logout()
    {
        _cachedAuthState = null;

    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        if (_cachedAuthState == null)
        {
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal()));
        }
        return await Task.FromResult(_cachedAuthState);



    }

}