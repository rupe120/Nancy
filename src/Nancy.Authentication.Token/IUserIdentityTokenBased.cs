using System.Security.Cryptography.X509Certificates;
using Nancy.Security;

namespace Nancy.Authentication.Token
{
    /// <summary>
    /// An extension of the user identity interface for tracking where the token came from
    /// </summary>
    public interface IUserIdentityTokenBased : IUserIdentity
    {
        /// <summary>
        /// Was the token was found in the header as opposed to a cookie?
        /// </summary>
        bool TokenFoundInHeader { get; set; }
    }
}