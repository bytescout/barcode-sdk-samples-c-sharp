## maxicode mode 2 3 postal barcode in C# and ByteScout Barcode SDK

### How to use ByteScout Barcode SDK for maxicode mode 2 3 postal barcode in C#

Writing of the code to maxicode mode 2 3 postal barcode in C# can be done by developers of any level using ByteScout Barcode SDK. ByteScout Barcode SDK was made to help with maxicode mode 2 3 postal barcode in C#. ByteScout Barcode SDK is the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images.

The SDK samples like this one below explain how to quickly make your application do maxicode mode 2 3 postal barcode in C# with the help of ByteScout Barcode SDK. This C# sample code should be copied and pasted into your application’s code editor. Then just compile and run it to see how it works. Further enhancement of the code will make it more vigorous.

On our website you may get trial version of ByteScout Barcode SDK for free. Source code samples are included to help you with your C# application.

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

##### ****PostalMaxiCode.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{7294EF89-FAB8-4424-AE5A-B0F7DF8A029F}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>PostalMaxiCode</RootNamespace>
    <AssemblyName>PostalMaxiCode</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=4.61.0.956, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Generator SDK\net2.00\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
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

<!-- code block begin -->

##### ****PostalMaxiCode.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 2013
VisualStudioVersion = 12.0.40629.0
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "PostalMaxiCode", "PostalMaxiCode.csproj", "{7294EF89-FAB8-4424-AE5A-B0F7DF8A029F}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{7294EF89-FAB8-4424-AE5A-B0F7DF8A029F}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{7294EF89-FAB8-4424-AE5A-B0F7DF8A029F}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{7294EF89-FAB8-4424-AE5A-B0F7DF8A029F}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{7294EF89-FAB8-4424-AE5A-B0F7DF8A029F}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using Bytescout.BarCode;

namespace PostalMaxiCode
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create and activate Barcode object instance
			Barcode barcode = new Barcode();
			barcode.RegistrationName = "demo";
			barcode.RegistrationKey = "demo";

			// Set barcode symbology (type) 
			barcode.Symbology = SymbologyType.MaxiCode;
			// Set MaxiCode mode
			barcode.Options.MaxiCodeMode = 2; // 2 or 3 depending on the postal code

			// Make barcode dots larger (5 pixels)
			barcode.NarrowBarWidth = 5;

			
			// Prepare barcode value:

			// Special data signatures
			string mode23Signature = "[)>" + '\x1E' + "01" + '\x1D' + "96";
			char separator = '\x1D';
			string endingSignature = "\x1E" + '\x04';

			// Mandatory data part.
			string postalCode = "123456789"; // 5 or 9 digits in the USA (Mode 2); 1-6 alphanumeric characters in other countries (Mode 3)
			string countryCode = "840"; // 3 digits (840 for USA) 
			string classOfService = "001"; // 3 digits 
			string trackingNumber = "S1Z12345678G"; // 10-character alphanumeric
			string upsStandardCarrierAlphaCode = "UPSN";

			// Optional data part.
			// Note, you can use empty strings for unneeded field values like `packageInShipment` or `weightInPounds` 
			// but they should delimited with the separator anyway.
			string upsShipperNumber = "S06X610"; // 6-character alphanumeric 
			string julianDayOfPickup = "159"; // 3 digits 
			string shipmentIdNumber = "1234567"; // 1-30 character alphanumeric 
			string packageInShipment = "1/2"; // 1-4 digits “/” 1-4 digits 
			string weightInPounds = "3.1"; // 1-5 digits
			string addressValidation = "Y"; // “Y” or “N”
			string shipToAddress = "S123 MAIN ST"; // 1-35 alphanumeric
			string shipToCity = "YORK"; // 1 - 35 alphanumeric
			string shipToState = "PA"; // 2-character alpha


			// Generate minimal postal code:

			string minimalValue = mode23Signature +
			                      postalCode + separator +
			                      countryCode + separator +
			                      classOfService + separator +
			                      trackingNumber + separator +
			                      upsStandardCarrierAlphaCode +
			                      endingSignature;

			barcode.Value = minimalValue;
			barcode.SaveImage("postal-maxicode-min.png");


			// Generate full postal code:

			string fullValue = mode23Signature +
			                   postalCode + separator +
			                   countryCode + separator +
			                   classOfService + separator +
			                   trackingNumber + separator +
			                   upsStandardCarrierAlphaCode + separator +
			                   upsShipperNumber + separator +
			                   julianDayOfPickup + separator +
			                   shipmentIdNumber + separator +
			                   packageInShipment + separator +
			                   weightInPounds + separator +
			                   addressValidation + separator +
			                   shipToAddress + separator +
			                   shipToCity + separator +
			                   shipToState +
			                   endingSignature;

			barcode.Value = fullValue;
			barcode.SaveImage("postal-maxicode-full.png");

			// Cleanup
			barcode.Dispose();
		}
	}
}

```

<!-- code block end -->