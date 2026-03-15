$errLog = "$env:TEMP\dotnet_err_$PID.log"
$proc = Start-Process "C:\Users\lenovo\Desktop\APPwork\work\cookwise\bin\Debug\net10.0-windows10.0.19041.0\win-x64\cookwise.exe" -PassThru -RedirectStandardError $errLog
Start-Sleep -Seconds 3
if ($proc.HasExited) {
    Write-Host "Exit Code: $($proc.ExitCode)"
    if (Test-Path $errLog) { Get-Content $errLog }
} else {
    Write-Host "Still running, PID: $($proc.Id)"
}