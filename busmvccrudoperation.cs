<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="..\packages\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.2.0.1\build\net46\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.props" Condition="Exists('..\packages\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.2.0.1\build\net46\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.props')" />
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{5DAC0A7E-BC8A-41A7-99AA-FA9C13D06E0B}</ProjectGuid>
    <ProjectTypeGuids>{349c5851-65df-11da-9384-00065b846f21};{fae04ec0-301f-11d3-bf4b-00c04f79efbc}</ProjectTypeGuids>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>BusMVCCrudOperation</RootNamespace>
    <AssemblyName>BusMVCCrudOperation</AssemblyName>
    <TargetFrameworkVersion>v4.7.2</TargetFrameworkVersion>
    <MvcBuildViews>false</MvcBuildViews>
    <UseIISExpress>true</UseIISExpress>
    <Use64BitIISExpress />
    <IISExpressSSLPort />
    <IISExpressAnonymousAuthentication />
    <IISExpressWindowsAuthentication />
    <IISExpressUseClassicPipelineMode />
    <UseGlobalApplicationHostFile />
    <NuGetPackageImportStamp>
    </NuGetPackageImportStamp>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="EntityFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089, processorArchitecture=MSIL">
      <HintPath>..\packages\EntityFramework.5.0.0\lib\net45\EntityFramework.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Data.Entity" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Runtime.Serialization" />
    <Reference Include="System.Security" />
    <Reference Include="System.Web.DynamicData" />
    <Reference Include="System.Web.Entity" />
    <Reference Include="System.Web.ApplicationServices" />
    <Reference Include="System.ComponentModel.DataAnnotations" />
    <Reference Include="System.Core" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Web" />
    <Reference Include="System.Web.Extensions" />
    <Reference Include="System.Web.Abstractions" />
    <Reference Include="System.Web.Routing" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Configuration" />
    <Reference Include="System.Web.Services" />
    <Reference Include="System.EnterpriseServices" />
    <Reference Include="Microsoft.Web.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.Web.Infrastructure.1.0.0.0\lib\net40\Microsoft.Web.Infrastructure.dll</HintPath>
    </Reference>
    <Reference Include="System.Net.Http">
    </Reference>
    <Reference Include="System.Net.Http.WebRequest">
    </Reference>
    <Reference Include="System.Web.Helpers, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.WebPages.3.2.7\lib\net45\System.Web.Helpers.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.Mvc, Version=5.2.7.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.Mvc.5.2.7\lib\net45\System.Web.Mvc.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.Optimization">
      <HintPath>..\packages\Microsoft.AspNet.Web.Optimization.1.1.3\lib\net40\System.Web.Optimization.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.Razor, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.Razor.3.2.7\lib\net45\System.Web.Razor.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.WebPages, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.WebPages.3.2.7\lib\net45\System.Web.WebPages.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.WebPages.Deployment, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.WebPages.3.2.7\lib\net45\System.Web.WebPages.Deployment.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.WebPages.Razor, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.WebPages.3.2.7\lib\net45\System.Web.WebPages.Razor.dll</HintPath>
    </Reference>
    <Reference Include="Newtonsoft.Json">
      <HintPath>..\packages\Newtonsoft.Json.12.0.2\lib\net45\Newtonsoft.Json.dll</HintPath>
    </Reference>
    <Reference Include="WebGrease">
      <Private>True</Private>
      <HintPath>..\packages\WebGrease.1.6.0\lib\WebGrease.dll</HintPath>
    </Reference>
    <Reference Include="Antlr3.Runtime">
      <Private>True</Private>
      <HintPath>..\packages\Antlr.3.5.0.2\lib\Antlr3.Runtime.dll</HintPath>
    </Reference>
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Microsoft.CodeDom.Providers.DotNetCompilerPlatform">
      <HintPath>..\packages\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.2.0.1\lib\net45\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.dll</HintPath>
    </Reference>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="App_Start\BundleConfig.cs" />
    <Compile Include="App_Start\FilterConfig.cs" />
    <Compile Include="App_Start\RouteConfig.cs" />
    <Compile Include="Context\BusTracking.cs">
      <DependentUpon>DbModel.tt</DependentUpon>
    </Compile>
    <Compile Include="Context\DbModel.Context.cs">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>DbModel.Context.tt</DependentUpon>
    </Compile>
    <Compile Include="Context\DbModel.cs">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>DbModel.tt</DependentUpon>
    </Compile>
    <Compile Include="Context\DbModel.Designer.cs">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>DbModel.edmx</DependentUpon>
    </Compile>
    <Compile Include="Controllers\BusController.cs" />
    <Compile Include="Controllers\HomeController.cs" />
    <Compile Include="Global.asax.cs">
      <DependentUpon>Global.asax</DependentUpon>
    </Compile>
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="Content\bootstrap-theme.css" />
    <Content Include="Content\bootstrap-theme.min.css" />
    <Content Include="Content\bootstrap.css" />
    <Content Include="Content\bootstrap.min.css" />
    <Content Include="Context\DbModel.Context.tt">
      <Generator>TextTemplatingFileGenerator</Generator>
      <LastGenOutput>DbModel.Context.cs</LastGenOutput>
      <DependentUpon>DbModel.edmx</DependentUpon>
    </Content>
    <Content Include="Context\DbModel.tt">
      <Generator>TextTemplatingFileGenerator</Generator>
      <DependentUpon>DbModel.edmx</DependentUpon>
      <LastGenOutput>DbModel.cs</LastGenOutput>
    </Content>
    <Content Include="favicon.ico" />
    <Content Include="fonts\glyphicons-halflings-regular.svg" />
    <Content Include="Global.asax" />
    <Content Include="Content\Site.css" />
    <Content Include="Scripts\bootstrap.js" />
    <Content Include="Scripts\bootstrap.min.js" />
    <EntityDeploy Include="Context\DbModel.edmx">
      <Generator>EntityModelCodeGenerator</Generator>
      <LastGenOutput>DbModel.Designer.cs</LastGenOutput>
    </EntityDeploy>
    <Content Include="Context\DbModel.edmx.diagram">
      <DependentUpon>DbModel.edmx</DependentUpon>
    </Content>
    <None Include="Scripts\jquery-3.4.1.intellisense.js" />
    <Content Include="Scripts\jquery-3.4.1.js" />
    <Content Include="Scripts\jquery-3.4.1.min.js" />
    <Content Include="Scripts\jquery-3.4.1.slim.js" />
    <Content Include="Scripts\jquery-3.4.1.slim.min.js" />
    <None Include="Scripts\jquery.validate-vsdoc.js" />
    <Content Include="Scripts\jquery.validate.js" />
    <Content Include="Scripts\jquery.validate.min.js" />
    <Content Include="Scripts\jquery.validate.unobtrusive.js" />
    <Content Include="Scripts\jquery.validate.unobtrusive.min.js" />
    <Content Include="Scripts\modernizr-2.8.3.js" />
    <Content Include="Web.config" />
    <Content Include="Web.Debug.config">
      <DependentUpon>Web.config</DependentUpon>
    </Content>
    <Content Include="Web.Release.config">
      <DependentUpon>Web.config</DependentUpon>
    </Content>
    <Content Include="Views\Web.config" />
    <Content Include="Views\_ViewStart.cshtml" />
    <Content Include="Views\Shared\Error.cshtml" />
    <Content Include="Views\Shared\_Layout.cshtml" />
    <Content Include="Views\Home\About.cshtml" />
    <Content Include="Views\Home\Contact.cshtml" />
    <Content Include="Views\Home\Index.cshtml" />
    <Content Include="Views\Bus\Bus.cshtml" />
    <Content Include="Views\Bus\BusList.cshtml" />
  </ItemGroup>
  <ItemGroup>
    <Folder Include="App_Data\" />
    <Folder Include="Models\" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="fonts\glyphicons-halflings-regular.woff2" />
    <Content Include="fonts\glyphicons-halflings-regular.woff" />
    <Content Include="fonts\glyphicons-halflings-regular.ttf" />
    <Content Include="fonts\glyphicons-halflings-regular.eot" />
    <Content Include="Content\bootstrap.min.css.map" />
    <Content Include="Content\bootstrap.css.map" />
    <Content Include="Content\bootstrap-theme.min.css.map" />
    <Content Include="Content\bootstrap-theme.css.map" />
    <None Include="packages.config" />
    <Content Include="Scripts\jquery-3.4.1.slim.min.map" />
    <Content Include="Scripts\jquery-3.4.1.min.map" />
  </ItemGroup>
  <ItemGroup>
    <Service Include="{508349B6-6B84-4DF5-91F0-309BEEBAD82D}" />
  </ItemGroup>
  <PropertyGroup>
    <VisualStudioVersion Condition="'$(VisualStudioVersion)' == ''">10.0</VisualStudioVersion>
    <VSToolsPath Condition="'$(VSToolsPath)' == ''">$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v$(VisualStudioVersion)</VSToolsPath>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
  <Import Project="$(VSToolsPath)\WebApplications\Microsoft.WebApplication.targets" Condition="'$(VSToolsPath)' != ''" />
  <Import Project="$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v10.0\WebApplications\Microsoft.WebApplication.targets" Condition="false" />
  <Target Name="MvcBuildViews" AfterTargets="AfterBuild" Condition="'$(MvcBuildViews)'=='true'">
    <AspNetCompiler VirtualPath="temp" PhysicalPath="$(WebProjectOutputDir)" />
  </Target>
  <ProjectExtensions>
    <VisualStudio>
      <FlavorProperties GUID="{349c5851-65df-11da-9384-00065b846f21}">
        <WebProjectProperties>
          <UseIIS>True</UseIIS>
          <AutoAssignPort>True</AutoAssignPort>
          <DevelopmentServerPort>59952</DevelopmentServerPort>
          <DevelopmentServerVPath>/</DevelopmentServerVPath>
          <IISUrl>http://localhost:59952/</IISUrl>
          <NTLMAuthentication>False</NTLMAuthentication>
          <UseCustomServer>False</UseCustomServer>
          <CustomServerUrl>
          </CustomServerUrl>
          <SaveServerSettingsInUserFile>False</SaveServerSettingsInUserFile>
        </WebProjectProperties>
      </FlavorProperties>
    </VisualStudio>
  </ProjectExtensions>
  <Target Name="EnsureNuGetPackageBuildImports" BeforeTargets="PrepareForBuild">
    <PropertyGroup>
      <ErrorText>This project references NuGet package(s) that are missing on this computer. Use NuGet Package Restore to download them.  For more information, see http://go.microsoft.com/fwlink/?LinkID=322105. The missing file is {0}.</ErrorText>
    </PropertyGroup>
    <Error Condition="!Exists('..\packages\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.2.0.1\build\net46\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.props')" Text="$([System.String]::Format('$(ErrorText)', '..\packages\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.2.0.1\build\net46\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.props'))" />
  </Target>
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it.
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target> -->
</Project>