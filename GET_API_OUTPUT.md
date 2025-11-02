# Instructions to Get API Output for Submission

## Step 1: Run the API
Open a terminal in the PizzaApi directory and run:
```
dotnet run
```

Wait for it to say "Now listening on: http://localhost:5000"

## Step 2: Get the Output

### Option A: Using Browser
1. Open your web browser
2. Navigate to: http://localhost:5000/api/pizza
3. Copy the entire JSON output you see

### Option B: Using PowerShell
In a NEW PowerShell window (keep the API running), run:
```powershell
Invoke-RestMethod -Uri "http://localhost:5000/api/pizza" | ConvertTo-Json
```
Then copy the output.

### Option C: Using curl
```powershell
curl http://localhost:5000/api/pizza
```

## Step 3: Update Submission Document
Copy the JSON output and replace the example output in W01_Assignment_Submission.txt

