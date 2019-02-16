using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitClient.Utility
{
    public class GitOctoClient
    {
        private const string _initApp = "my-cool-app";

        private static GitOctoClient _intance;
        private static string _gitUrl;
        private Credentials storeCrd;


        public static GitOctoClient Instane(string gitUrl)
        {
            if (_intance == null || !_gitUrl.Equals(gitUrl, StringComparison.InvariantCultureIgnoreCase))
            {
                _intance = new GitOctoClient(gitUrl);

            }
            return _intance;
        }

        public GitOctoClient(string gitUrl)
        {
            _gitUrl = gitUrl;
        }

        public async Task<bool> ValdateCredentilas(string userId, string psw)
        {
            bool isEnterpriseGit = false;
            var ghe = new Uri(_gitUrl);
            var probe = new EnterpriseProbe(new ProductHeaderValue(_initApp));
            var result = await probe.Probe(ghe);
            if (result == EnterpriseProbeResult.Ok)
            {
                isEnterpriseGit = true;
            }
            var client = new GitHubClient(new ProductHeaderValue(_initApp));
            storeCrd = new Credentials(userId, psw);
            client.Credentials = storeCrd;
            var user = await client.User.Current();
            return isEnterpriseGit && (user.TotalPrivateRepos > 0);
        }
    }
}
