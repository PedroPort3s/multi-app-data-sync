
# Small Chat Application (WinForm & WebBlazor Clients)
This repository contains the source code for a small chat application that demonstrates communication between clients and a server using SignalR.

## Project Structure
The project is divided into several sub-projects:

### Clients
* **WinForm** A Windows Forms application that allows users to send and receive messages.
* **WebBlazor** A Blazor WebAssembly application that allows users to send and receive messages within a web browser.
### Server
* **WebServer** An ASP.NET Core web API that hosts the SignalR server and manages communication with clients.
### Infrastructure
* Defines commonly used external dependencies between projects.
### Models
* Common domain models that are shared with other projects
* 

## Get Started

To run the project, you will need the most recent version of:
* Visual Studio Community (or other version) 2022
* .Net 8 SDK

Also, it is required to run at least one client project or (ideally) both client projects. To do that, you need to configure multiple projects as startup in Visual Studio:

1. Clone the project
2. Open the .sln file
3. In Visual Studio, right-click on the Solution file in the Solution Explorer menu (ctrl + alt + L)
    1. "Configure Startup Projects..." option in the context menu
    2. Check the "Multiple Startup projects:" option in the opened screen
    3. WinForm, WebBlazor, and WebServer projects should have their Action column with a "Start" value
    4. Click "Apply"
4. Run the solution, by hitting F5 or the "Start" option at the top of Visual Studio's UI.

### WebServer

It will open a console tab with all URLs, to communicate with it, other projects should use the https://localhost:7181 address.


### WinForm
The project is running when a grey window appears, you should add WebServer's URL above and click on "Connect". You can also open another instance of this client application by clicking in the "New Instance" button.

A message box will appear informing that the connection was made and the Input textbox will be enabled, just type the text and click in "Submit".

Every message sent and received should appear in the Output component.

### WebBlazor

A browser window will appear with a blank home page, click on the "Chat" option on the left side menu. The application will connect automatically with that WebServer URL (hardcoded in Chat.razor component, located in WebBlazor.Client -> Pages -> Chat.razor line 70). 

A label will appear on the screen saying where it is connected and you can type the input text and click on the "Submit" blue button. An HTML list will render with every received/sent message.
