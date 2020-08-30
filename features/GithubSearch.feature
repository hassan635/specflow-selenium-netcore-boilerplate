Feature: Github Search
              As a programmer, I want to search Github,
              so that I can get this boilerplate project code
  
        Scenario: Github repository search
            Given I navigate to Github
             When I search for user "hassan635"
              And I navigate to user "hassan635" repositories
             Then I can see the repository for "projectname" in the results