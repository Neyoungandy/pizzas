# Script to get API output for submission
# Make sure the PizzaApi is running first!

Write-Host "Fetching API output from http://localhost:5000/api/pizza..." -ForegroundColor Yellow

try {
    $response = Invoke-RestMethod -Uri "http://localhost:5000/api/pizza" -Method Get
    
    Write-Host "`n=== API OUTPUT (Copy this) ===" -ForegroundColor Green
    $jsonOutput = $response | ConvertTo-Json -Depth 10
    Write-Host $jsonOutput -ForegroundColor White
    Write-Host "`n=== END OUTPUT ===" -ForegroundColor Green
    
    # Save to file
    $jsonOutput | Out-File -FilePath "api-output.txt" -Encoding utf8
    Write-Host "`nOutput also saved to: api-output.txt" -ForegroundColor Cyan
}
catch {
    Write-Host "ERROR: Could not connect to API. Make sure PizzaApi is running!" -ForegroundColor Red
    Write-Host "Run 'dotnet run' in the PizzaApi directory first." -ForegroundColor Yellow
}

