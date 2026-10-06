## ASP Configuration and Options Demonstration

Simple ASP blog app to demonstrate the Options pattern for site configuration.

### Explanation
This ASP app uses the Options pattern to allow for easy site configuration. 
It has an options class named `SiteSettings` which allows for the configuration of `SiteName`, and `EnableComments`.  

These options can be modified through the `appsettings.json` file and modifying them changes certain features of the website:  
<img width="353" height="121" alt="site-options" src="https://github.com/user-attachments/assets/2afb2f10-c3af-41f2-8401-3df2c3ed3e94" />



### Site Name
Modifying `SiteName` changes the name displayed on the navigation bar and in other various locations:  
<img width="629" height="375" alt="site-name" src="https://github.com/user-attachments/assets/d8d074df-64c2-4663-9b8c-149ce3bffef9" />

### Enable Comments
Modifying `EnableComments` determines whether to display a comment form at the bottom of the post details pages:  
#### Enable comments true
<img width="629" height="375" alt="comment-true" src="https://github.com/user-attachments/assets/5bbd974d-1b9f-457c-a2fe-c7207f311d26" />

#### Enable comments false
<img width="629" height="375" alt="comment-false" src="https://github.com/user-attachments/assets/77ddc93b-666d-43f6-8c95-c59e7f0c4f60" />  

### Development Configuration
There is also a separate configuration file called `appsettings.Development.json` which is used to modify these settings in the development 
environment. This is used to enable comments only in development builds as they are not fully implemented.   
<img width="318" height="104" alt="dev-options" src="https://github.com/user-attachments/assets/9b8437ca-28b3-4007-996e-114902a161c5" />
