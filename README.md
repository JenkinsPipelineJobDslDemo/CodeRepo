# TestCIIntegration
Repostiory for testing jenkins integration containing the actual source code and a simple 'Jenkinsfile' to trigger CI.

Within the CI system, only one Job (i.e. GitHub Organization job) will be created. This job will detect the 'Jenkinsfile' which triggers library code within the 'SharedCILibrary' repository which shall scan this 'CodeRepo' repository for sln files, and dynamically create new jobs for those using the job-DSL plugin.

Manual configuration for Jenkins:

1. Create the GitHub Organization job in jenkins pointing to the JenkinsPipelineJobDslDemo organization
  This will scan the organization and search for repos (and branches) containing Jenkinsfile.
  In this case the CodeRepo will be detected.
2. Specify the 'SharedCILibrary' as global pipeline library in jenkins management config so that it is trusted and running out of groovy    sandbox and is implicitely loaded to every pipeline (i.e. Jenkinsfile).

Automatic behaviour (simplified):

When the GitHub Organization job detects any change (e.g. by GitHub notification) or is triggered manually, it will detect the 'Master' branch and run its jenkinsfile.

The Jenkinsfile in the master branch will call the dotNetStandardPipeline located in the shared libraries repo (This works perfectly)

The dotNetStandardPipeline will trigger the DotNetJob.groovy script that shall create jobs dynamically for each sln file within the CodeRepo repository (This is not working and I'm running out of ideas)
