ApiKey=$1
Source=$2

# Defining the version here for consistent versioning across packages, may segregate later on
Version="5.0.${3}"

# Core packages that need to be packed prior to any other packages
nuget pack ./src/X12.Specifications/package.nuspec -Version $Version -Verbosity detailed
nuget pack ./src/X12.Shared/package.nuspec -Version $Version -Verbosity detailed
nuget pack ./src/X12.Transformations/package.nuspec -Version $Version -Verbosity detailed
nuget pack ./src/X12.Parsing/package.nuspec -Version $Version -Verbosity detailed

# Supplemental packages to pack
nuget pack ./src/X12.Validation/package.nuspec -Version $Version -Verbosity detailed
nuget pack ./src/X12.Sql/package.nuspec -Version $Version -Verbosity detailed
nuget pack ./src/X12.Hipaa/package.nuspec -Version $Version -Verbosity detailed

# Publish the packages
nuget setApiKey $ApiKey -Source $Source -Verbosity detailed
nuget push X12.*.nupkg -Source $Source