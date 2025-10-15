# ComPortCheck.ps1
# 利用可能なシリアルポート一覧を表示し、
# ユーザーがEnterを押すたびに再取得します。
$exePath = "C:\Program Files (x86)\Project1\全半比較.exe"



Start-Process -FilePath $exePath 
# Clear-Host
Write-Host "=== COMポート一覧ツール ===`n"

do {
    # 現在のポート一覧取得
    $ports = [System.IO.Ports.SerialPort]::GetPortNames()

    if ($ports.Count -eq 0) {
        Write-Host "利用可能なポートはありません。"
    }
    else {
        Write-Host "現在利用可能なポート:"
        foreach ($p in $ports) {
            Write-Host "  $p"
        }
    }

    Write-Host "`n再読み込みするには [Enter]、終了するには [Q] を押してください。"
    $key = Read-Host
    Clear-Host
    Write-Host "=== COMポート一覧ツール ===`n"

} while ($key -ne "q" -and $key -ne "Q")

Write-Host "終了しました。"
