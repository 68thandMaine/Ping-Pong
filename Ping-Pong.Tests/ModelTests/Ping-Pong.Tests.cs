<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>netcoreapp1.1</TargetFramework>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="15.0.0" />
    <PackageReference Include="MSTest.TestAdapter" Version="1.2" />
    <PackageReference Include="MSTest.TestFramework" Version="1.2" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Ping-Pong\Ping-Pong.csproj" />
  </ItemGroup>

</Project>
