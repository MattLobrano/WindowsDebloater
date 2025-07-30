# Remove Cortana for current user
Get-AppxPackage -Name "*Microsoft.549981C3F5F10*" | Remove-AppxPackage -ErrorAction SilentlyContinue

# Remove Cortana from system provisioned packages
Get-AppxProvisionedPackage -Online | Where-Object DisplayName -like "*Microsoft.549981C3F5F10*" | ForEach-Object {
    Remove-AppxProvisionedPackage -Online -PackageName $_.PackageName -ErrorAction SilentlyContinue
}
