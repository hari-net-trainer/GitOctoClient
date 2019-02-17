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
        private GitHubClient gitClient;

        public static GitOctoClient Instane(string gitUrl)
        {
            if (_intance == null || !_gitUrl.Equals(gitUrl, StringComparison.InvariantCultureIgnoreCase))
            {
                _intance = new GitOctoClient(gitUrl);

            }
            return _intance;
        }

        private GitOctoClient(string gitUrl)
        {
            _gitUrl = gitUrl;
        }

        //public async Task<bool> ValdateCredentilas(string userId, string psw)
        public int ValdateCredentilas(string userId, string psw)
        {
            bool isEnterpriseGit = false;
            try
            {
                //var ghe = new Uri(_gitUrl);
                //var probe = new EnterpriseProbe(new ProductHeaderValue(_initApp));
                //var result = await probe.Probe(ghe);
                //if (result == EnterpriseProbeResult.Ok)
                //{
                //    isEnterpriseGit = true;
                //}
                gitClient = new GitHubClient(new ProductHeaderValue(_initApp));
                storeCrd = new Credentials(userId, psw);
                gitClient.Credentials = storeCrd;
                var user = gitClient.User.Current().Result;
                return user.PublicRepos;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        //public async Task<IEnumerable<Repository>> GetRepos()
        public IEnumerable<Repository> GetRepos()
        {
            var repos = gitClient.Repository.GetAllForCurrent().Result;

            return repos;
        }
    }
}
