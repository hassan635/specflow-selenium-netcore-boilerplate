using System;

using TechTalk.SpecFlow;

namespace specflow_selenium_netcore_boilerplate.src.steps
{
    [Binding]
    public class GithubSearchsSteps
    {
        [Given(@"I navigate to Github")]
        public void NavigateToGithub()
        {
            Console.WriteLine("From Step: I navigate to Github");
        }

        [When(@"I search for user (.*)")]
        public void SearchForGithubUser(string username)
        {
            Console.WriteLine($"From Step: I search for user {username}");
        }

        [When(@"I navigate to user (.*) repositories")]
        public void NavigateToUserRepositories(string username)
        {
            Console.WriteLine($"From Step: I navigate to user {username} repositories");
        }

        [Then(@"I can see the repository for (.*) in the results")]
        public void VerifyTargetRepositoryVisible(string repositoryName)
        {
            Console.WriteLine($"From Step: I can see the repository for {repositoryName} in the results");
        }
    }
}
