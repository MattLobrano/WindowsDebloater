# Remove installed Xbox-related apps for all users
Get-AppxPackage -AllUsers *Xbox* | Remove-AppxPackage -AllUsers

# Remove provisioned packages so they don’t return
Get-AppxProvisionedPackage -Online | Where-Object DisplayName -like "*Xbox*" | Remove-AppxProvisionedPackage -Online

# Optional: Also remove Game Bar & other related components
Get-AppxPackage -AllUsers *GamingApp* | Remove-AppxPackage -AllUsers
Get-AppxProvisionedPackage -Online | Where-Object DisplayName -like "*GamingApp*" | Remove-AppxProvisionedPackage -Online

Get-AppxPackage -AllUsers *XboxGameCallableUI* | Remove-AppxPackage -AllUsers
Get-AppxProvisionedPackage -Online | Where-Object DisplayName -like "*XboxGameCallableUI*" | Remove-AppxProvisionedPackage -Online
