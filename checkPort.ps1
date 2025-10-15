# 利用可能なシリアルポート一覧を表示
Write-Host "Available Serial Ports:`n"
[System.IO.Ports.SerialPort]::GetPortNames() | ForEach-Object {
    Write-Host $_
}
