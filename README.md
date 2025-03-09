## Develop AI agent with .Net Aspire

.Net Aspire is running under .Net8/9 frameowrk. it is the new .net dev tool to be used to develop distributed app, api service, blazor, opentlemetry, and app host app can be built and dployed in one solution. this one-stop solntion can be deployed into cloud as distributed app, such app is
different from the traditional distributed app. one solution can be installed in different resources such as cloud web service, docker, or k8s,etc.

.net Aspire contains asp.net core API service, AppHost orchestrate dashboard, web front end, and servicedefaults that implement telemetry to monitor the product, espically when solution is deployed into clouds.

.Net Aspire AppHost, hookup all projects together to orchestrate it

.Net servicedefaults implements telemetry to monitor product.

.Net API service provide microservices for asp.net web front end.

.net web front end sends requests web or AI requests to AppHost which coordinate the requests to be sent to the correct server APPHost for processing. responses can be displayed in Blazor front end UI app.

AI blazor UI send questions to APPHost, which forward requests to OLLMAMA client which talks to OLLMaMa Hugging face AI models to get results back.

## workflow

blazor web front end---->requests---->ollama client------>APPHost AI models------>responses---->blazor web front end

## AI Agent

web front end contains a normal page that sends question user inputed to ollama client to get answer from Hugging face pre-trained AI Model that could be orchestrated in APPHOST. AppHost can be deployed locally , therefore, every time  balzor run will need oLLAMA model.
how do we know the model is running, we can see this status from dashboard.

## deployment

use azure deveploer CLI to do so

>azd init command will collect all necessary deployment parameters and create a deploy.yaml to deploy.
>
>azd up command will stsrt deployment steps to push entire solution to cloud and implement it.
>
>azd monitor will monitor all steps.

