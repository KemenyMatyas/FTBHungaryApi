namespace Common.Infrastructure;

using System.Security.Claims;
using Microsoft.AspNetCore.Http;

public class AppContext : IAppContext
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    
    public AppContext(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;

    }



    public int? UserId
    {
        get
        {
            try
            {
                return int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.UserData).Value);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
        
    

    public string UserDisplayName
    {
        get
        {
            try
            {
                return _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;
            }
            catch (Exception e)
            {
                return "";
            }
        }
    }



    public virtual bool IsAuthenticated
    {
        get
        {
            var user = _httpContextAccessor.HttpContext?.User;
            if (user != null)
            {
                return user.Identity?.IsAuthenticated ?? false;
            }
            return false;
        }

    }
}