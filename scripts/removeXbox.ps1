# Remove Xbox for current user
Get-AppxPackage *xbox* | Remove-AppxPackage

# Remove provisioned Xbox packages for all users
Get-AppxProvisionedPackage -Online | Where-Object DisplayName -like "*xbox*" | Remove-AppxProvisionedPackage -Online

