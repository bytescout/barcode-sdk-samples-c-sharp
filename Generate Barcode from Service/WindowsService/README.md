## How to generate barcode from service for windows service in C# with ByteScout Barcode SDK

### Tutorial: how to generate barcode from service for windows service in C#

Every ByteScout tool contains example C# source codes that you can find here or in the folder with installed ByteScout product. Windows service in C# can be implemented with ByteScout Barcode SDK. ByteScout Barcode SDK is the robost library (Software Development Kit) that is designed for automatic generation of high-quality barcodes for printing, electronic documents and pdf. All popular barcode types are supported from Code 39 and Code 129 to QR Code, UPC, GS1, GS-128, Datamatrix, PDF417, Maxicode and many others. Provides support for full customization of fonts, colors, output and printing sizes. Special tools are included to verify output quality and printing quality. Can add generated barcode into new or existing documents, images and PDF.

C# code snippet like this for ByteScout Barcode SDK works best when you need to quickly implement windows service in your C# application. Open your C# project and simply copy & paste the code and then run your app! Further enhancement of the code will make it more vigorous.

ByteScout free trial version is available for FREE download from our website. Programming tutorials along with source code samples are included.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=REnj3A-oSPI](https://www.youtube.com/watch?v=REnj3A-oSPI)




<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Text;

namespace WindowsService1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] servicesToRun = new ServiceBase[] { new Service1() };

            ServiceBase.Run(servicesToRun);
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ProjectInstaller.Designer.cs:**
    
```
namespace WindowsService1
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstaller1 = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller1
            // 
            this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstaller1.Password = null;
            this.serviceProcessInstaller1.Username = null;
            // 
            // serviceInstaller1
            // 
            this.serviceInstaller1.ServiceName = "Service1";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller1,
            this.serviceInstaller1});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller1;
        private System.ServiceProcess.ServiceInstaller serviceInstaller1;
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ProjectInstaller.cs:**
    
```
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;


namespace WindowsService1
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Service1.Designer.cs:**
    
```
namespace WindowsService1
{
    partial class Service1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            // 
            // Service1
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Service1.cs:**
    
```
using System;
using System.IO;
using System.ServiceProcess;
using System.Timers;
using Bytescout.BarCode;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
	    private Timer _timer = null;

        public Service1()
        {
            InitializeComponent();

            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            {
                System.Diagnostics.EventLog.CreateEventSource( "MySource", "MyNewLog");
            }
            
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("In OnStart");

			if (_timer != null)
			{
				_timer.Stop();
				_timer.Elapsed -= Timer_Elapsed;
				_timer.Dispose();
			}

			_timer = new Timer(5000);
			_timer.Elapsed += Timer_Elapsed;
			_timer.Start();
        }

	    protected override void OnStop()
        {
			eventLog1.WriteEntry("In OnStop.");
			
			if (_timer != null)
			{
				_timer.Stop();
				_timer.Elapsed -= Timer_Elapsed;
				_timer.Dispose();
				_timer = null;
			}
        }

	    void Timer_Elapsed(object sender, ElapsedEventArgs e)
	    {
		    Barcode barcode = null;

		    try
		    {
		    	// Generate sample barcode value by random number
			    Random random = new Random();
				string barcodeValue = "(00)" + random.Next().ToString("000000000000000000");

				// Create Bytescout.BarCode object and setup the barcode
			    barcode = new Barcode("demo", "demo");
			    barcode.Symbology = SymbologyType.GS1_128;
			    barcode.Value = barcodeValue;

			    string outputDirectory = "c:\\barcodes";
		        if (!Directory.Exists(outputDirectory))
		            Directory.CreateDirectory(outputDirectory);

		        string fileName = barcodeValue + ".pdf";
			    string filePath = Path.Combine(outputDirectory, fileName);

                // Save barcode to new PDF file
				barcode.DrawToNewPDF(filePath, 500, 500, 50, 50);

				eventLog1.WriteEntry("Generated " + fileName);

				// Sending email message example:
				/*
				System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
				message.To.Add("luckyperson@online.microsoft.com");
				message.Subject = fileName;
				message.From = new System.Net.Mail.MailAddress("From@online.microsoft.com");
				message.Body = "This is the message body";
				message.Attachments.Add(new System.Net.Mail.Attachment(filePath));
				
				System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("your_smtp_host");
				smtp.Send(message);
				*/
		    }
			catch (Exception exception)
			{
				eventLog1.WriteEntry(exception.Message);
			}
		    finally
		    {
			    if (barcode != null)
			    {
				    barcode.Dispose();
			    }
		    }
	    }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****WindowsService1.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.30703</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{6DDA9D0B-FB9C-47F9-8783-B6159F4F1857}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>WindowsService1</RootNamespace>
    <AssemblyName>WindowsService1</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup>
    <StartupObject>WindowsService1.Program</StartupObject>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|AnyCPU'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|AnyCPU'">
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=2.2.0.413, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\Program Files\Bytescout BarCode SDK\net2.00\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Configuration.Install" />
    <Reference Include="System.Data" />
    <Reference Include="System.Management" />
    <Reference Include="System.ServiceProcess" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="ProjectInstaller.cs">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="ProjectInstaller.Designer.cs">
      <DependentUpon>ProjectInstaller.cs</DependentUpon>
    </Compile>
    <Compile Include="Service1.cs">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="Service1.Designer.cs">
      <DependentUpon>Service1.cs</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="ProjectInstaller.resx">
      <DependentUpon>ProjectInstaller.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Service1.resx">
      <DependentUpon>Service1.cs</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>
```

<!-- code block end -->