Set-Location frontend
npm run build
Set-Location ..
Remove-Item -Path "Thales/wwwroot/*" -Recurse
Copy-Item -Path "frontend/dist/*" -Destination "Thales/wwwroot" -Recurse
Set-Location Thales
dotnet run