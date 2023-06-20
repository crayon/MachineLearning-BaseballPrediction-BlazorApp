**Baseball Machine Learning Workbench**
is a web application that showcases performing decision analysis (decision thresholding, what-if analysis) using in-memory Machine Learning models with baseball data.

![Baseball ML Workbench](https://github.com/crayon/MachineLearning-BaseballPrediction-BlazorApp/blob/master/BaseballMLWorkbenchDemo.gif)

**The application has the following features:**
Sequence Diagram & Architecture Narrative 
 
Introduction: An architectural overview that combines SignalR, Azure services, and Machine Learning to create an intelligent and responsive system for delivering real-time user experiences. By leveraging distributed communication, cloud content delivery, decision analysis, and machine learning, organizations can enhance their applications' capabilities and provide personalized insights to end-users. 
1.	Distributed Communication with SignalR: The Client User Interface (UI) acting as the front-end component where users interact with the application. The UI sends data to and receives results from SignalR, a powerful real-time messaging framework. SignalR enables distributed communication between the server and end-users, ensuring seamless and responsive updates. With SignalR, users can receive real-time data and notifications, enabling interactive and dynamic user experiences. 
2.	Integration with Azure Front Door: SignalR interfaces with Azure Front Door, a cloud content delivery network (CDN), to optimize data transmission. Azure Front Door acts as a global load balancer and routing service, efficiently directing data traffic to the nearest edge location. By leveraging Azure Front Door, SignalR can deliver data quickly, reducing latency and enhancing the overall performance of the real-time communication between the server and end-users. 
3.	Leveraging Azure App Service for Decision Analysis: Azure App Service, a managed web app hosting platform, serves as the intermediary between the UI and the Machine Learning Workbench - Decision Analysis module. The UI sends data to Azure App Service, which then passes it to the Decision Analysis module. Built on ASP.NET 7.x, the Machine Learning Workbench utilizes Blazor Server and ML.NET, empowering organizations to integrate decision rules with the UI seamlessly. This integration allows for intelligent decision-making and personalized insights based on user data. 
4.	4 & 5. Integration with ML.NET for Predictive Analytics: The Decision Analysis module communicates with the Machine Learning Models, which are built using ML.NET. ML.NET offers in-memory predictive models for analyzing baseball data. By leveraging ML.NET, organizations can apply advanced analytics and machine learning algorithms to generate valuable insights and predictions. The Machine Learning Models process data received from the Decision Analysis module, providing intelligent recommendations and predictive outcomes. 
6.	Azure Function for Advanced Processing: To further enhance the system's capabilities, the Machine Learning Models make use of an Azure Function. The Azure Function acts as an intermediary component, enabling additional processing and leveraging various Azure services. It incorporates Generative AI by utilizing Microsoft Bing's current knowledge graph of the internet and Azure OpenAI's capabilities (Utilizing Semantic Kernel). These technologies are combined to generate AI-generated narratives enriched with decision analysis. Additionally, Azure Cache for Redis, a distributed cache, is employed, utilizing the exploration vs. exploitation pattern to surface and search narratives efficiently. 
7.	Logging and Instrumentation with Azure App Insights: To ensure effective monitoring and troubleshooting, Azure App Insights is integrated into the architecture. Azure App Insights provides comprehensive application logging and instrumentation capabilities, enabling developers and administrators to gain insights into system performance, track exceptions, and monitor user interactions. This facilitates proactive identification of issues, optimization of the system, and continuous improvement of the overall user experience. 
 
Conclusion: By combining SignalR, Azure services, and Machine Learning, organizations can create a powerful architecture that delivers real-time user experiences, personalized insights, and intelligent decision-making. The distributed communication, cloud content delivery, decision analysis, and machine learning capabilities enable applications to provide responsive, interactive, and data-driven experiences to end-users. Leveraging the full potential of these technologies empowers organizations to stay ahead in the competitive landscape by delivering exceptional user experiences. 


**Architecture - Cloud Deployment Diagram:**
![Baseball ML Workbench - Architecture Deployment Diagram](https://github.com/crayon/MachineLearning-BaseballPrediction-BlazorApp/blob/master/BaseballMLWorkbench-Architecture-DeploymentDiagram.png)

**Project Structure (Verified):**
* Visual Studio 2019 v4.0 for Windows/Mac - Visual Studio 2022, .NET Core 3.x - .NET 6, Server-Side Blazor, ML.NET v1.5 - v1.7, Azure SignalR (optional for massively scaling message communication for Azure deployments)
* Note: Updated Azure service versions or NuGet package references could work

**More Information:**
* ML.NET: https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet
* Blazor: https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor
* Historical Baseball Statistics Database (used as the model training and inference data set): http://www.seanlahman.com/baseball-archive/statistics/
* How to Measure Anything (Amazon book link): https://www.amazon.com/How-Measure-Anything-Intangibles-Business-ebook/dp/B00INUYS2U/ref=sr_1_1?dchild=1&keywords=how+to+measure+anything&qid=1588713606&sr=8-1
* Decision Management Systems (Amazon book link): https://www.amazon.com/Decision-Management-Systems-Practical-Predictive/dp/0132884380

