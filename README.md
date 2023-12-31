1. Installs
    1. java (jdk version >= 11)
    1. sonarscanner (follow guidelines in sonarqube portal)
    1. dotCover https://docs.sonarsource.com/sonarqube/latest/analyzing-source-code/test-coverage/dotnet-test-coverage/#dotcover

1. Spin up SonarQube locally by docker-compose
    1. Open *powershell* at **./sonarqube-docker/** directory
    1. Run below command in *powershell* to spin up SonarQube
        ```
        docker-compose up
        ```

1. How to use
    1. Access to SonarQube portal by the endpoint `http://localhost:9000` with default credentials admin/admin

1. Run these command to scan projects
    1. Open *powershell* at **./src/** directory
    1. Run below commands in *powershell* to analyze the project 
        ```
        dotnet sonarscanner begin /k:"bi-sonarqube-first-action" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="<SONARQUBE_TOKEN>" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
        dotnet build
        dotnet dotcover test --dcReportType=HTML
        dotnet sonarscanner end /d:sonar.token="<SONARQUBE_TOKEN>"
        ```

1. Known issues
    1. https://stackoverflow.com/questions/51445846/elasticsearch-max-virtual-memory-areas-vm-max-map-count-65530-is-too-low-inc
