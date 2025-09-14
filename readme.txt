Case Studies - CI/CD with .NET Core and GitHub Actions

Case Study 1:
-------------
Library application needs to be referenced in xUnit application.
xUnit application needs to be referenced in API application.

Connection_string: 
------------------
Example:
"Server=tcp:githubcicdserver.database.windows.net,1433;Initial Catalog=GitHubCICDDB;Persist Security Info=False;
User ID=githubAdmin@githubcicdserver;Password=Kanuj@6583;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection
Timeout=30"

Case Study 2:
-------------
1. Concept of Deployment Centre:
   Authenticate and Authorize between Azure Subscription and DevOps.

2. Deployment Group:
   Own Agent IIS and Azure ACR act as bridge for deployment.

3. CI/CD Multistage YAML:
   Separate build and release pipelines if required.
   Service connection recommended for secure CI/CD integration.

------------------------------------------

Pipelines for CI/CD

A. .NET Core WebAPI + Azure SQL Server + CI/CD + Azure DevOps (Deployed on Azure WebApps).
   - .NET Core running locally
   - Push to GitHub
   - Open Azure DevOps → Service Connections (Authenticate Azure Subscription)
   - Generate pipeline for build and release on Azure Web App.

   Repo URL: https://github.com/kanuj114/AzureCICDWithDevOpsOnAzureWebApps.git
   Requirement: Provide the Connection_string of Azure SQL server.

B. .NET Core WebAPI + Azure SQL Server + CI/CD + Azure DevOps (Deployed on IIS).
   - DotNet Core + GitHub = pipeline = Agent = Release (Deployment)
   - VM or agent by Deployment group
   - Eligible to deploy on IIS Server

------------------------------------------

Troubleshooting:
- Ensure agents are properly configured (self-hosted agent required for Azure DevOps).
- Verify service connections for authentication with Azure Subscription.
- Use multistage YAML pipelines for structured CI/CD process.
